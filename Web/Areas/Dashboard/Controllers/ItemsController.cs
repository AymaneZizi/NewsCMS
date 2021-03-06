﻿using Kendo.Mvc.UI;
using System;
using System.Linq;
using System.Web.Mvc;
using Mn.NewsCms.Common;

namespace Mn.NewsCms.Web.Areas.Dashboard.Controllers
{
    public partial class ItemsManagmentController : BaseAdminController
    {
        private readonly IFeedItemBusiness _feedItemBusiness;

        public ItemsManagmentController(IFeedItemBusiness feedItemBusiness)
        {
            _feedItemBusiness = feedItemBusiness;
        }

        public virtual ActionResult Index()
        {
            var items = _feedItemBusiness.FeedItemsByTime(DateTime.Now, 20, 0);
            return View(items);
        }
        public virtual JsonResult ReadData([DataSourceRequest] DataSourceRequest request)
        {
            var query = _feedItemBusiness.GetList().OrderByDescending(item => item.CreateDate);

            var result = new DataSourceResult()
            {
                Data = query.Skip((request.Page - 1) * request.PageSize).Take(request.PageSize).ToList().Select(item => new FeedItem()
                {
                    CreateDate = item.CreateDate,
                    Deleted = item.Deleted,
                    FeedId = item.FeedId,
                    Id = item.Id,
                    Link = item.Link,
                    PubDate = item.PubDate,
                    ShowContentType = item.ShowContentType,
                    SiteTitle = item.SiteTitle,
                    SiteUrl = item.SiteUrl,
                    Title = item.Title,
                    VisitsCount = item.VisitsCount
                }).ToList(),
                Total = query.Count()
            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}