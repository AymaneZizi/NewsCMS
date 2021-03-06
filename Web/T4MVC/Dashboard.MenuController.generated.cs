// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Mn.NewsCms.Web.Areas.Dashboard.Controllers
{
    public partial class MenuController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected MenuController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult MenuItem_Read()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.MenuItem_Read);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult ManageItem()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.ManageItem);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult DeleteItem()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteItem);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public MenuController Actions { get { return MVC.Dashboard.Menu; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Dashboard";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Menu";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Menu";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string MenuItem_Read = "MenuItem_Read";
            public readonly string ManageItem = "ManageItem";
            public readonly string DeleteItem = "DeleteItem";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string MenuItem_Read = "MenuItem_Read";
            public const string ManageItem = "ManageItem";
            public const string DeleteItem = "DeleteItem";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string menuId = "menuId";
        }
        static readonly ActionParamsClass_MenuItem_Read s_params_MenuItem_Read = new ActionParamsClass_MenuItem_Read();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_MenuItem_Read MenuItem_ReadParams { get { return s_params_MenuItem_Read; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_MenuItem_Read
        {
            public readonly string request = "request";
            public readonly string menuId = "menuId";
        }
        static readonly ActionParamsClass_ManageItem s_params_ManageItem = new ActionParamsClass_ManageItem();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ManageItem ManageItemParams { get { return s_params_ManageItem; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ManageItem
        {
            public readonly string id = "id";
            public readonly string item = "item";
        }
        static readonly ActionParamsClass_DeleteItem s_params_DeleteItem = new ActionParamsClass_DeleteItem();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteItem DeleteItemParams { get { return s_params_DeleteItem; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteItem
        {
            public readonly string id = "id";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Index = "Index";
            }
            public readonly string Index = "~/Areas/Dashboard/Views/Menu/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_MenuController : Mn.NewsCms.Web.Areas.Dashboard.Controllers.MenuController
    {
        public T4MVC_MenuController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? menuId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(int? menuId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "menuId", menuId);
            IndexOverride(callInfo, menuId);
            return callInfo;
        }

        [NonAction]
        partial void MenuItem_ReadOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, Kendo.Mvc.UI.DataSourceRequest request, int? menuId);

        [NonAction]
        public override System.Web.Mvc.JsonResult MenuItem_Read(Kendo.Mvc.UI.DataSourceRequest request, int? menuId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.MenuItem_Read);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "request", request);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "menuId", menuId);
            MenuItem_ReadOverride(callInfo, request, menuId);
            return callInfo;
        }

        [NonAction]
        partial void ManageItemOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.JsonResult ManageItem(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.ManageItem);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ManageItemOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void ManageItemOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, Mn.NewsCms.Common.Navigation.MenuItem item);

        [NonAction]
        public override System.Web.Mvc.JsonResult ManageItem(Mn.NewsCms.Common.Navigation.MenuItem item)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.ManageItem);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "item", item);
            ManageItemOverride(callInfo, item);
            return callInfo;
        }

        [NonAction]
        partial void DeleteItemOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.JsonResult DeleteItem(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteItem);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DeleteItemOverride(callInfo, id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
