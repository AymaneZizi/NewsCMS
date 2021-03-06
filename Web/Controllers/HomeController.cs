﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Mn.NewsCms.Common.Models;
using Mn.NewsCms.Common;
using Mn.NewsCms.Common.Config;
using Mn.NewsCms.Web.WebLogic;
using Mn.NewsCms.Web.Models;
using Mn.NewsCms.Web.Models.Shared;

namespace Mn.NewsCms.Web.Controllers
{
    public partial class HomeController : BaseController
    {
        private readonly ITagBusiness _tagBusiness;
        private readonly ICategoryBusiness _categoryBusiness;
        private readonly IAppConfigBiz _appConfigBiz;
        private readonly IFeedItemBusiness _feedItemBusiness;
        private readonly ISiteBusiness _siteBusiness;
        private readonly IUserBusiness _userBusiness;
        const int IndexItemsWidget = 6;//number of items panel in index page
        //const int IndexVisualPost = 4;//number of visual post in index page

        public HomeController(ITagBusiness tagBusiness, ICategoryBusiness categoryBusiness, IAppConfigBiz appConfigBiz,
            IFeedItemBusiness feedItemBusiness, ISiteBusiness siteBusiness, IUserBusiness userBusiness)
        {
            _tagBusiness = tagBusiness;
            _categoryBusiness = categoryBusiness;
            _appConfigBiz = appConfigBiz;
            _feedItemBusiness = feedItemBusiness;
            _siteBusiness = siteBusiness;
            _userBusiness = userBusiness;
        }


        [OutputCache(Duration = CmsConfig.Cache5Min)]
        public virtual ActionResult Index()
        {
            var Model = new HomeViewModel();
            #region colors
            Model.Colors = new List<string> { "rgba(8, 134, 190, 0.8)", "rgba(130, 181, 71, 0.8)", "rgba(120, 66, 147, 0.8) ", "rgba(255, 0, 57, 0.8)", "rgba(255, 117, 24, 0.8)", "rgba(39, 128, 227, 0.8)", "rgba(20, 156, 130, 0.8)", "rgba(153, 84, 187, 0.8)" };
            Model.Colors.Reverse();
            Model.Colors.AddRange(Model.Colors);
            Model.Colors.Reverse();
            Model.Colors.AddRange(Model.Colors);
            #endregion
            #region ViewBag
            ViewBag.Title = "رسانه خبری";
            ViewBag.Description = "تازه ترین و جدیدترین اخبار و فایل های صوتی و تصویری";
            ViewBag.KeyWords = @"اخبار روز, اخبار ورزشی ,جدیدترین رادیوها,دانلود سخنرانی, خبرخوان,موتور جستجو,نرم افزار موبایل,farsi media";
            ViewBag.EntityCode = "Home";
            ViewBag.EntityRef = 0;
            ViewBag.defaultIndex = 1;

            #endregion
            #region Top Tags
            var itags = HttpContext.Cache.Get("IndexTags");
            if (itags != null)
                Model.TopTags = HttpContext.Cache.Get("IndexTags") as List<Tag>;
            else
            {
                Model.TopTags = _tagBusiness.GetList().Where(t => t.InIndex && !string.IsNullOrEmpty(t.ImageThumbnail)).Shuffle().Take(40).ToList();
                HttpContext.Cache.AddToCache("IndexTags", Model.TopTags, 40);
            }
            #endregion
            #region Items
            var cats = _categoryBusiness.GetList()
                .Where(x => x.ViewMode == Common.Share.ViewMode.Index || x.ViewMode == Common.Share.ViewMode.MenuIndex)
                .OrderByDescending(x => x.Priority).ToList();

            foreach (var cat in cats.Take(8))
            {
                var sliderModel = new SliderModel() { Code = cat.Code };
                if (_appConfigBiz.GetConfig<bool>(Constants.EnabledOptions.IndexPhotoHeadlines))
                    sliderModel.Items = _feedItemBusiness.GetList().Where(i => i.Feed.Categories.Any(c => (c.Id == cat.Id || c.ParentId == cat.Id) && i.HasPhoto))
                        .OrderByDescending(i => i.PubDate).Take(4).ToList().Select(i => new SliderItemModel()
                        {
                            Description = i.Description,
                            Link = string.Concat("/site/", i.SiteUrl, "/", i.ItemId, "/", i.Title.RemoveBadCharacterInURL()),
                            ImageURL = string.Concat("/", _appConfigBiz.VisualItemsPathVirtual().ToLower(), "/", i.Id, ".jpg"),
                            PubDate = i.PubDate.Value,
                            Title = i.Title,
                            VisitsCount = i.VisitsCount,
                            Refrence = i.SiteTitle
                        }).ToList();

                var res = _feedItemBusiness.FeedItemsByCat(cat.Id, 12, 0, 10).ToList();

                Model.CatItems.Add(new HomeItemsPanelViewModel() { ShowMoreBtn = true, Cat = cat, Items = res.ToList(), slider = sliderModel });
            }
            Model.Categories = _categoryBusiness.GetList().Where(x => x.ViewMode != Common.Share.ViewMode.NotShow).ToList();
            #endregion
            #region Post
            //Model.Posts = _postBiz.GetList().Where(p => p.PostType == PostType.News && !p.MetaData.IsDeleted && p.PublishDate <= DateTime.Now)
            //    .Select(p => new PostModel()
            //    {
            //        Id = p.Id,
            //        Title = p.Title,
            //        SubTitle = p.SubTitle,
            //        PublishDate = p.PublishDate,
            //        PostImage = p.PostImage,
            //        VisitCount = p.VisitCount,
            //        LikeCount = p.LikeCount,
            //        DislikeCount = p.DislikeCount,
            //    }).Take(Ioc.AppConfigBiz.GetConfig<int>(Constants.Home.VisualPostCount)).ToList();

            //Model.Videos = _postBiz.GetList().Where(p => p.PostType == PostType.Video && !p.MetaData.IsDeleted && p.PublishDate <= DateTime.Now)
            //   .Select(p => new PostModel()
            //   {
            //       Id = p.Id,
            //       Title = p.Title,
            //       SubTitle = p.SubTitle,
            //       PublishDate = p.PublishDate,
            //       PostImage = p.PostImage,
            //       VisitCount = p.VisitCount,
            //       LikeCount = p.LikeCount,
            //       DislikeCount = p.DislikeCount,
            //   }).Take(Ioc.AppConfigBiz.GetConfig<int>(Constants.Home.VisualPostCount)).ToList();
            #endregion
            #region MostVisited
            var mosteItems = _feedItemBusiness.MostVisitedItems("today", 10, 15, 10).ToList();
            // if (mosteItems != null && mosteItems.Any())
            Model.MostVisitedItems = new HomeItemsPanelViewModel()
            {
                Items = mosteItems.ToList(),
                Cat = new Category() { Code = "news", Title = "پربازدیدترین ها", Color = Model.Colors[2] },
                // CssClass = "col-md-4",
                ShowMoreBtn = false
            };
            #endregion
            #region Top Site
            Model.TopSites = _siteBusiness.GetTopSites(20, 120);
            #endregion         

            return View("Index." + CmsConfig.ThemeName, Model);
        }

        [OutputCache(Duration = CmsConfig.Cache10Min)]
        public virtual ActionResult Review()
        {
            var dd = DateTime.Now.ToString("yyyyMMddHHmmss");
            return View();
        }

        [AjaxOnly]
        [OutputCache(Duration = CmsConfig.Cache5Min, VaryByParam = "Content;PageIndex")]
        public virtual ActionResult FeedItems(string Content, int PageIndex, string type = "cat")
        {
            if (PageIndex > 5)
                PageIndex = 5;

            ViewBag.Content = Content;
            string tagTitle = string.Empty;
            IEnumerable<FeedItem> res;
            if (type == "cat")
                res = _feedItemBusiness.FeedItemsByCat(ref Content, 10, PageIndex);
            else
                res = _feedItemBusiness.FeedItemsByTag(Content, 10, PageIndex, ref tagTitle);

            #region viewBag
            ViewBag.Type = type;
            ViewBag.PageIndex = PageIndex + 1;
            ViewBag.PageHeader = "تازه ترین های " + Content;
            #endregion

            return PartialView("_MoreItems", res);
        }

        [OutputCache(Duration = CmsConfig.Cache3Hour)]
        public virtual ActionResult About()
        {
            return RedirectToAction(MVC.Page.ActionNames.Index, MVC.Page.Name, new { pageName = Constants.Pages.AboutPostName });
        }

        [OutputCache(Duration = CmsConfig.Cache3Hour)]
        public virtual ActionResult Contact()
        {
            return RedirectToAction(MVC.Page.ActionNames.Index, MVC.Page.Name, new { pageName = Constants.Pages.ContactPostName });
        }

        [HttpPost]
        public bool Contact(string name, string email, string tell, string title, string message, MessageType type = MessageType.Contact)
        {
            try
            {
                //_contactBusiness.AddContact(new ContactMessage
                //{
                //    CreateDate = DateTime.Now,
                //    Name = name,
                //    Email = email,
                //    Phone = tell,
                //    Title = title,
                //    Message = message,
                //    Type = type
                //});
                return true;
            }
            catch
            {
                return false;
            }

        }

        [OutputCache(Duration = CmsConfig.Cache3Hour)]
        public virtual ActionResult ads()
        {
            return RedirectToAction(MVC.Page.ActionNames.Index, MVC.Page.Name, new { pageName = Constants.Pages.AdstPostName });
        }

        [OutputCache(Duration = CmsConfig.Cache3Hour)]
        public virtual ActionResult techs()
        {
            return RedirectToAction(MVC.Page.ActionNames.Index, MVC.Page.Name, new { pageName = Constants.Pages.TechPostName });
        }

        [HttpGet]
        public string UserView()
        {
            if (User.Identity.IsAuthenticated)
                return "خوش آمدی " + new CmsMembership(_userBusiness).GetCurrentUserTitle();
            return string.Empty;
        }

        [OutputCache(Duration = CmsConfig.Cache10Min, VaryByParam = "src")]
        public virtual ActionResult Script(string src)
        {
            src = src.IndexOfX("http://") < 0 ? "http://" + src : src;
            ViewBag.Src = src;
            ViewBag.Code = src.Replace("http://", string.Empty).Replace("/", "_");
            return PartialView("_Script");
        }

        public virtual ActionResult Video()
        {
            return View();
        }

        [HttpGet]
        [OutputCache(Duration = CmsConfig.Cache3Hour)]
        public string Tags()
        {
            return string.Join(":", _tagBusiness.GetList().Select(t => t.Value.Replace("|", ":")).ToList());
        }
    }
}
