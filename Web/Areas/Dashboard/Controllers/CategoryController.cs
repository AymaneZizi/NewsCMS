﻿using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mn.NewsCms.Web.Models;
using Mn.NewsCms.Common;
using Mn.NewsCms.Web.WebLogic;
using Mn.NewsCms.Web.WebLogic.BaseModel;

namespace Mn.NewsCms.Web.Areas.Dashboard.Controllers
{
    public partial class CategoryController : BaseAdminController
    {
        private readonly ICategoryBusiness _categoryBusiness;
        private readonly IFeedBusiness _feedBusiness;

        public CategoryController(ICategoryBusiness categoryBusiness, IFeedBusiness feedBusiness)
        {
            _categoryBusiness = categoryBusiness;
            _feedBusiness = feedBusiness;
        }


        [Authorize(Roles = "admin")]
        public virtual ActionResult Index()
        {
            var model = new PageGridModel();
            model.GridMenu = new ColumnActionMenu(new ColumnActionMenu.ActionMenuItem(ColumnActionMenu.ItemType.ScriptCommand, Mn.NewsCms.Common.Resources.General.Edit, "openModal('/Dashboard/Category/Manage/#=Id#')"),
                new ColumnActionMenu.ActionMenuItem(ColumnActionMenu.ItemType.ScriptCommand, Mn.NewsCms.Common.Resources.General.Delete, "deleteGridRow('/Dashboard/Category/Delete/#=Id#')"));

            return View(model);
        }

        public virtual JsonNetResult Category_Read([DataSourceRequest] DataSourceRequest request, long? feedId)
        {
            var query = _categoryBusiness.GetList();
            if (feedId.HasValue)
                query = _categoryBusiness.GetList().Where(c => c.Feeds.Any(f => f.Id == feedId));

            var cats = query.Select(c => new CategoryViewModel()
            {
                Id = c.Id,
                Code = c.Code,
                Title = c.Title,
                Color = c.Color,
                Priority = c.Priority,
                ViewMode = c.ViewMode
            }).ToList();

            return JsonNet(cats.ToDataSourceResult(request));
        }

        public virtual JsonResult AddFeedToCat(int catId, int feedId)
        {
            var feed = _feedBusiness.Get(feedId);
            var cat = _categoryBusiness.Get(catId);
            feed.Categories.Add(cat);
            _feedBusiness.Edit(feed);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public virtual JsonResult RemoveFeedFromCat(int feedId)//int catId, long feedId
        {
            var feed = _feedBusiness.Get(feedId);
            var cat = _categoryBusiness.Get(int.Parse(Request.Params["Id"]));
            feed.Categories.Remove(cat);
            _feedBusiness.Edit(feed);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public virtual ActionResult Manage(int Id)
        {
            var model = new CategoryModel();
            if (Id != 0)
                model = _categoryBusiness.Get(Id).ToViewModel<CategoryModel>();

            var cats =_categoryBusiness.GetList().Where(c => c.Active).Select(c => new DropDownListItem() { Value = c.Id.ToString(), Text = c.Title }).ToList();
            cats.Insert(0, new DropDownListItem() { Text = "بدون سرگروه", Value = "0" });
            ViewBag.Cats = cats;

            return View(model);
        }

        [HttpPost]
        public virtual JsonResult Manage(Category category)
        {
            var res =_categoryBusiness.CreateEdit(category);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}