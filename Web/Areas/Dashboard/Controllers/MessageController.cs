﻿using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mn.NewsCms.Common.Content;
using Mn.NewsCms.Common.Models;
using Mn.NewsCms.Web.WebLogic.BaseModel;

namespace Mn.NewsCms.Web.Areas.Dashboard.Controllers
{
    public partial class MessageController : BaseAdminController
    {
        private readonly IContactBusiness _contactBusiness;

        public MessageController(IContactBusiness contactBusiness)
        {
            _contactBusiness = contactBusiness;
        }

        // GET: Dashboard/Message
        public virtual ActionResult Index()
        {
            var model = new PageGridModel();
            model.GridMenu = new ColumnActionMenu(new ColumnActionMenu.ActionMenuItem(Common.Resources.General.Edit, "/Dashboard/Meesage/Manage/#=Id#"),
                new ColumnActionMenu.ActionMenuItem(ColumnActionMenu.ItemType.ScriptCommand, Mn.NewsCms.Common.Resources.General.Delete, "deleteGridRow('/Dashboard/Message/Delete/#=Id#')"),
                new ColumnActionMenu.ActionMenuItem(ColumnActionMenu.ItemType.ScriptCommand, "خواندن", "readMessage('/Dashboard/Message/Read/#=Id#')"));
            return View(model);
        }
        public virtual ActionResult Read(int id)
        {
            var msg = _contactBusiness.GetList().SingleOrDefault(m => m.Id == id);
            if (!msg.IsRead)
            {
                msg.IsRead = true;
                _contactBusiness.Edit(msg);
            }
            return View(msg);
        }
        public virtual JsonResult Messages_Read([DataSourceRequest] DataSourceRequest request, MessageType type = MessageType.Contact)
        {
            if (!request.Sorts.Any())
            {
                request.Sorts.Add(new Kendo.Mvc.SortDescriptor("Id", System.ComponentModel.ListSortDirection.Descending));
            }
            var query = _contactBusiness.GetList();
            var model = query.Where(m => m.Type == type).Select(m => new
            {
                m.Id,
                m.CreateDate,
                m.Email,
                m.Name,
                m.Phone,
                m.Title,
            });
            return Json(model.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
    }
}