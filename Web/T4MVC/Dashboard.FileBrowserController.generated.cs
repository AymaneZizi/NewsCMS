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
    public partial class FileBrowserController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public FileBrowserController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected FileBrowserController(Dummy d) { }

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
        public virtual System.Web.Mvc.JsonResult Read()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.Read);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Destroy()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Destroy);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Create()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Upload()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Upload);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public FileBrowserController Actions { get { return MVC.Dashboard.FileBrowser; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Dashboard";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "FileBrowser";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "FileBrowser";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Read = "Read";
            public readonly string Destroy = "Destroy";
            public readonly string Create = "Create";
            public readonly string Upload = "Upload";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Read = "Read";
            public const string Destroy = "Destroy";
            public const string Create = "Create";
            public const string Upload = "Upload";
        }


        static readonly ActionParamsClass_Read s_params_Read = new ActionParamsClass_Read();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Read ReadParams { get { return s_params_Read; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Read
        {
            public readonly string path = "path";
        }
        static readonly ActionParamsClass_Destroy s_params_Destroy = new ActionParamsClass_Destroy();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Destroy DestroyParams { get { return s_params_Destroy; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Destroy
        {
            public readonly string path = "path";
            public readonly string entry = "entry";
        }
        static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Create
        {
            public readonly string path = "path";
            public readonly string entry = "entry";
        }
        static readonly ActionParamsClass_Upload s_params_Upload = new ActionParamsClass_Upload();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Upload UploadParams { get { return s_params_Upload; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Upload
        {
            public readonly string path = "path";
            public readonly string file = "file";
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
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_FileBrowserController : Mn.NewsCms.Web.Areas.Dashboard.Controllers.FileBrowserController
    {
        public T4MVC_FileBrowserController() : base(Dummy.Instance) { }

        [NonAction]
        partial void ReadOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string path);

        [NonAction]
        public override System.Web.Mvc.JsonResult Read(string path)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.Read);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "path", path);
            ReadOverride(callInfo, path);
            return callInfo;
        }

        [NonAction]
        partial void DestroyOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string path, Kendo.Mvc.UI.FileBrowserEntry entry);

        [NonAction]
        public override System.Web.Mvc.ActionResult Destroy(string path, Kendo.Mvc.UI.FileBrowserEntry entry)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Destroy);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "path", path);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "entry", entry);
            DestroyOverride(callInfo, path, entry);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string path, Kendo.Mvc.UI.FileBrowserEntry entry);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create(string path, Kendo.Mvc.UI.FileBrowserEntry entry)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "path", path);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "entry", entry);
            CreateOverride(callInfo, path, entry);
            return callInfo;
        }

        [NonAction]
        partial void UploadOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string path, System.Web.HttpPostedFileBase file);

        [NonAction]
        public override System.Web.Mvc.ActionResult Upload(string path, System.Web.HttpPostedFileBase file)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Upload);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "path", path);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "file", file);
            UploadOverride(callInfo, path, file);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
