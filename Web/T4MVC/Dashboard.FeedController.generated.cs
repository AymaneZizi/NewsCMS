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
namespace Tazeyab.Web.Areas.Dashboard.Controllers
{
    public partial class FeedController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public FeedController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected FeedController(Dummy d) { }

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
        public virtual System.Web.Mvc.JsonResult Feeds_Read()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.Feeds_Read);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CreateEdit()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateEdit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult Feed_CreateEdit()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.Feed_CreateEdit);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public FeedController Actions { get { return MVC.Dashboard.Feed; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Dashboard";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Feed";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Feed";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Feeds_Read = "Feeds_Read";
            public readonly string CreateEdit = "CreateEdit";
            public readonly string Feed_CreateEdit = "Feed_CreateEdit";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Feeds_Read = "Feeds_Read";
            public const string CreateEdit = "CreateEdit";
            public const string Feed_CreateEdit = "Feed_CreateEdit";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string siteId = "siteId";
            public readonly string catId = "catId";
            public readonly string term = "term";
        }
        static readonly ActionParamsClass_Feeds_Read s_params_Feeds_Read = new ActionParamsClass_Feeds_Read();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Feeds_Read Feeds_ReadParams { get { return s_params_Feeds_Read; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Feeds_Read
        {
            public readonly string request = "request";
            public readonly string siteId = "siteId";
            public readonly string catId = "catId";
            public readonly string term = "term";
        }
        static readonly ActionParamsClass_CreateEdit s_params_CreateEdit = new ActionParamsClass_CreateEdit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CreateEdit CreateEditParams { get { return s_params_CreateEdit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CreateEdit
        {
            public readonly string Id = "Id";
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_Feed_CreateEdit s_params_Feed_CreateEdit = new ActionParamsClass_Feed_CreateEdit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Feed_CreateEdit Feed_CreateEditParams { get { return s_params_Feed_CreateEdit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Feed_CreateEdit
        {
            public readonly string feed = "feed";
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
                public readonly string CreateEdit = "CreateEdit";
                public readonly string Index = "Index";
            }
            public readonly string CreateEdit = "~/Areas/Dashboard/Views/Feed/CreateEdit.cshtml";
            public readonly string Index = "~/Areas/Dashboard/Views/Feed/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_FeedController : Tazeyab.Web.Areas.Dashboard.Controllers.FeedController
    {
        public T4MVC_FeedController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long? siteId, long? catId, string term);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(long? siteId, long? catId, string term)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "siteId", siteId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "catId", catId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            IndexOverride(callInfo, siteId, catId, term);
            return callInfo;
        }

        [NonAction]
        partial void Feeds_ReadOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, Kendo.Mvc.UI.DataSourceRequest request, long? siteId, long? catId, string term);

        [NonAction]
        public override System.Web.Mvc.JsonResult Feeds_Read(Kendo.Mvc.UI.DataSourceRequest request, long? siteId, long? catId, string term)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.Feeds_Read);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "request", request);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "siteId", siteId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "catId", catId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            Feeds_ReadOverride(callInfo, request, siteId, catId, term);
            return callInfo;
        }

        [NonAction]
        partial void CreateEditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long? Id);

        [NonAction]
        public override System.Web.Mvc.ActionResult CreateEdit(long? Id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateEdit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Id", Id);
            CreateEditOverride(callInfo, Id);
            return callInfo;
        }

        [NonAction]
        partial void CreateEditOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, Tazeyab.Web.Models.FeedViewModel model);

        [NonAction]
        public override System.Web.Mvc.JsonResult CreateEdit(Tazeyab.Web.Models.FeedViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.CreateEdit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            CreateEditOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void Feed_CreateEditOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, Tazeyab.Common.Feed feed);

        [NonAction]
        public override System.Web.Mvc.JsonResult Feed_CreateEdit(Tazeyab.Common.Feed feed)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.Feed_CreateEdit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "feed", feed);
            Feed_CreateEditOverride(callInfo, feed);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
