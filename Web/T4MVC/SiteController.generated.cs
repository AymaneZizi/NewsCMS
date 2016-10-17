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
namespace Tazeyab.Web.Controllers
{
    public partial class SiteController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SiteController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SiteController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult FeedItems()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FeedItems);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult FeedItemsRemote()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FeedItemsRemote);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ViewResult Page()
        {
            return new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Page);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult All()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.All);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SiteController Actions { get { return MVC.Site; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Site";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Site";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string FeedItems = "FeedItems";
            public readonly string FeedItemsRemote = "FeedItemsRemote";
            public readonly string Page = "Page";
            public readonly string All = "All";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string FeedItems = "FeedItems";
            public const string FeedItemsRemote = "FeedItemsRemote";
            public const string Page = "Page";
            public const string All = "All";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string Content = "Content";
            public readonly string PageIndex = "PageIndex";
        }
        static readonly ActionParamsClass_FeedItems s_params_FeedItems = new ActionParamsClass_FeedItems();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_FeedItems FeedItemsParams { get { return s_params_FeedItems; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_FeedItems
        {
            public readonly string Content = "Content";
            public readonly string PageIndex = "PageIndex";
        }
        static readonly ActionParamsClass_FeedItemsRemote s_params_FeedItemsRemote = new ActionParamsClass_FeedItemsRemote();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_FeedItemsRemote FeedItemsRemoteParams { get { return s_params_FeedItemsRemote; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_FeedItemsRemote
        {
            public readonly string Content = "Content";
            public readonly string PageSize = "PageSize";
        }
        static readonly ActionParamsClass_Page s_params_Page = new ActionParamsClass_Page();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Page PageParams { get { return s_params_Page; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Page
        {
            public readonly string SiteLink = "SiteLink";
            public readonly string FeedItemId = "FeedItemId";
            public readonly string ItemTitle = "ItemTitle";
        }
        static readonly ActionParamsClass_All s_params_All = new ActionParamsClass_All();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_All AllParams { get { return s_params_All; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_All
        {
            public readonly string UserName = "UserName";
            public readonly string c = "c";
            public readonly string TopCount = "TopCount";
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
                public readonly string All = "All";
                public readonly string All_Sekuzan = "All.Sekuzan";
                public readonly string All_Tazeyab = "All.Tazeyab";
                public readonly string Index_Sekuzan = "Index.Sekuzan";
                public readonly string Index_Tazeyab = "Index.Tazeyab";
                public readonly string Page_Sekuzan = "Page.Sekuzan";
                public readonly string Page_Tazeyab = "Page.Tazeyab";
            }
            public readonly string All = "~/Views/Site/All.cshtml";
            public readonly string All_Sekuzan = "~/Views/Site/All.Sekuzan.cshtml";
            public readonly string All_Tazeyab = "~/Views/Site/All.Tazeyab.cshtml";
            public readonly string Index_Sekuzan = "~/Views/Site/Index.Sekuzan.cshtml";
            public readonly string Index_Tazeyab = "~/Views/Site/Index.Tazeyab.cshtml";
            public readonly string Page_Sekuzan = "~/Views/Site/Page.Sekuzan.cshtml";
            public readonly string Page_Tazeyab = "~/Views/Site/Page.Tazeyab.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_SiteController : Tazeyab.Web.Controllers.SiteController
    {
        public T4MVC_SiteController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string Content, int PageIndex);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(string Content, int PageIndex)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Content", Content);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "PageIndex", PageIndex);
            IndexOverride(callInfo, Content, PageIndex);
            return callInfo;
        }

        [NonAction]
        partial void FeedItemsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string Content, int PageIndex);

        [NonAction]
        public override System.Web.Mvc.ActionResult FeedItems(string Content, int PageIndex)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FeedItems);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Content", Content);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "PageIndex", PageIndex);
            FeedItemsOverride(callInfo, Content, PageIndex);
            return callInfo;
        }

        [NonAction]
        partial void FeedItemsRemoteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string Content, int PageSize);

        [NonAction]
        public override System.Web.Mvc.ActionResult FeedItemsRemote(string Content, int PageSize)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FeedItemsRemote);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Content", Content);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "PageSize", PageSize);
            FeedItemsRemoteOverride(callInfo, Content, PageSize);
            return callInfo;
        }

        [NonAction]
        partial void PageOverride(T4MVC_System_Web_Mvc_ViewResult callInfo, string SiteLink, string FeedItemId, string ItemTitle);

        [NonAction]
        public override System.Web.Mvc.ViewResult Page(string SiteLink, string FeedItemId, string ItemTitle)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Page);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "SiteLink", SiteLink);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "FeedItemId", FeedItemId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ItemTitle", ItemTitle);
            PageOverride(callInfo, SiteLink, FeedItemId, ItemTitle);
            return callInfo;
        }

        [NonAction]
        partial void AllOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string UserName, string c, int TopCount);

        [NonAction]
        public override System.Web.Mvc.ActionResult All(string UserName, string c, int TopCount)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.All);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "UserName", UserName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "c", c);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "TopCount", TopCount);
            AllOverride(callInfo, UserName, c, TopCount);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
