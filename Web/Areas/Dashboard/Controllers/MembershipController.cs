﻿using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mn.NewsCms.Web.Models.Membership;
using Microsoft.AspNet.Identity.Owin;
using Mn.NewsCms.Common;
using Mn.NewsCms.Common.BaseClass;
using Mn.NewsCms.Common.Membership;
using Mn.NewsCms.Web.WebLogic.BaseModel;

namespace Mn.NewsCms.Web.Areas.Dashboard.Controllers
{
    public partial class MembershipController : BaseAdminController
    {
        private readonly IUserBusiness _userBusiness;

        public MembershipController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        // GET: Dashboard/Membership
        public virtual ActionResult Index()
        {
            var model = new PageGridModel();
            model.GridMenu = new ColumnActionMenu(new ColumnActionMenu.ActionMenuItem(Common.Resources.General.Edit, "/Dashboard/Membership/Manage/#=Id#"),
                new ColumnActionMenu.ActionMenuItem(ColumnActionMenu.ItemType.ScriptCommand, Common.Resources.General.Delete, "deleteGridRow('/Dashboard/Membership/Delete/#=Id#')"));
            return View(model);
        }
        public virtual ActionResult Role()
        {
            ViewBag.Roles = _userBusiness.GetRoleList().Select(r => new { r.Id, r.Name });
            return View();
        }
        public virtual JsonResult Users_Read([DataSourceRequest] DataSourceRequest request)
        {
            var query = _userBusiness.GetList();
            var model = query.Select(u => new
            {
                u.Id,
                u.UserName,
                u.CreateDate,
                u.Email,
                u.FirstName,
                u.LastName,
                u.Roles,
            });
            return Json(model.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public virtual ActionResult Manage(int? Id)
        {
            UserModel model;
            if (Id.HasValue)
            {
                var dbUser = _userBusiness.GetList().SingleOrDefault(a => a.Id == Id.Value);
                model = dbUser.ToViewModel<UserModel>();
                model.SelectedRoles = dbUser.Roles.Select(c => c.RoleId).ToList();
                ViewBag.Roles = HttpContext.GetOwinContext().Get<ApplicationRoleManager>().Roles
                    .Select(c => new MnTitleValue() { Title = c.Name, Value = c.Id }).ToList();
            }
            else
                model = new UserModel();

            return View(model);
        }
        [HttpPost]
        public virtual JsonResult Manage(UserModel model)
        {
            var res = new OperationStatus();
            if (ModelState.IsValid)
            {
                var dbUser = _userBusiness.GetList().SingleOrDefault(a => a.Id == model.Id);
                dbUser = model.ToModel(dbUser);
                if (model.SelectedRoles != null)
                {
                    var roles = HttpContext.GetOwinContext().Get<ApplicationRoleManager>().Roles
                        .Where(r => model.SelectedRoles.Contains(r.Id)).ToList().Select(r => new UserRole() { RoleId = r.Id, UserId = dbUser.Id }).ToList();
                    foreach (var role in roles)
                    {
                        if (!dbUser.Roles.Any(r => r.RoleId == role.RoleId))
                            dbUser.Roles.Add(role);
                    }
                }

                res = _userBusiness.Update(dbUser);
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}