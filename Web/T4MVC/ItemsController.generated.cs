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
namespace Mn.NewsCms.Web.Controllers
{
    public partial class ItemsController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ItemsController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult MostVisitedItems()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.MostVisitedItems);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ItemsController Actions { get { return MVC.Items; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Items";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Items";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string MostVisitedItems = "MostVisitedItems";
            public readonly string TodayMostVisitedItems = "TodayMostVisitedItems";
            public readonly string TodayMostVisited = "TodayMostVisited";
            public readonly string Now = "Now";
            public readonly string LastVisited = "LastVisited";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string MostVisitedItems = "MostVisitedItems";
            public const string TodayMostVisitedItems = "TodayMostVisitedItems";
            public const string TodayMostVisited = "TodayMostVisited";
            public const string Now = "Now";
            public const string LastVisited = "LastVisited";
        }


        static readonly ActionParamsClass_MostVisitedItems s_params_MostVisitedItems = new ActionParamsClass_MostVisitedItems();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_MostVisitedItems MostVisitedItemsParams { get { return s_params_MostVisitedItems; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_MostVisitedItems
        {
            public readonly string EntityCode = "EntityCode";
            public readonly string EntityRef = "EntityRef";
            public readonly string PageSize = "PageSize";
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
                public readonly string _MostVisitedItems = "_MostVisitedItems";
                public readonly string _TodayMostVisitedItems = "_TodayMostVisitedItems";
                public readonly string _VisualItemList = "_VisualItemList";
                public readonly string LastVisited = "LastVisited";
                public readonly string Now = "Now";
                public readonly string TodayMostVisited = "TodayMostVisited";
            }
            public readonly string _MostVisitedItems = "~/Views/Items/_MostVisitedItems.cshtml";
            public readonly string _TodayMostVisitedItems = "~/Views/Items/_TodayMostVisitedItems.cshtml";
            public readonly string _VisualItemList = "~/Views/Items/_VisualItemList.cshtml";
            public readonly string LastVisited = "~/Views/Items/LastVisited.cshtml";
            public readonly string Now = "~/Views/Items/Now.cshtml";
            public readonly string TodayMostVisited = "~/Views/Items/TodayMostVisited.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ItemsController : Mn.NewsCms.Web.Controllers.ItemsController
    {
        public T4MVC_ItemsController() : base(Dummy.Instance) { }

        [NonAction]
        partial void MostVisitedItemsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string EntityCode, int EntityRef, int PageSize);

        [NonAction]
        public override System.Web.Mvc.ActionResult MostVisitedItems(string EntityCode, int EntityRef, int PageSize)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.MostVisitedItems);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "EntityCode", EntityCode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "EntityRef", EntityRef);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "PageSize", PageSize);
            MostVisitedItemsOverride(callInfo, EntityCode, EntityRef, PageSize);
            return callInfo;
        }

        [NonAction]
        partial void TodayMostVisitedItemsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult TodayMostVisitedItems()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TodayMostVisitedItems);
            TodayMostVisitedItemsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void TodayMostVisitedOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult TodayMostVisited()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TodayMostVisited);
            TodayMostVisitedOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void NowOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Now()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Now);
            NowOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void LastVisitedOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult LastVisited()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LastVisited);
            LastVisitedOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
