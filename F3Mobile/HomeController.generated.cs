// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
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
namespace F3Mobile.Controllers
{
    public partial class HomeController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HomeController(Dummy d) { }

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


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "home";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "home";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = ("Index").ToLowerInvariant();
            public readonly string Fng = ("Fng").ToLowerInvariant();
            public readonly string Schedule = ("Schedule").ToLowerInvariant();
        }


        static readonly ActionParamsClass_Fng s_params_Fng = new ActionParamsClass_Fng();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Fng FngParams { get { return s_params_Fng; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Fng
        {
            public readonly string contact = ("contact").ToLowerInvariant();
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
                public readonly string Contact = "Contact";
                public readonly string ContactAsnyc = "ContactAsnyc";
                public readonly string fng = "fng";
                public readonly string Index = "Index";
                public readonly string Schedule = "Schedule";
            }
            public readonly string Contact = "~/Views/Home/Contact.cshtml";
            public readonly string ContactAsnyc = "~/Views/Home/ContactAsnyc.cshtml";
            public readonly string fng = "~/Views/Home/fng.cshtml";
            public readonly string Index = "~/Views/Home/Index.cshtml";
            public readonly string Schedule = "~/Views/Home/Schedule.cshtml";
            static readonly _DisplayTemplateClass s_DisplayTemplate = new _DisplayTemplateClass();
            public _DisplayTemplateClass DisplayTemplate { get { return s_DisplayTemplate; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _DisplayTemplateClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string News = "News";
                }
                public readonly string News = "~/Views/Home/DisplayTemplate/News.cshtml";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : F3Mobile.Controllers.HomeController
    {
        public T4MVC_HomeController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void FngOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Fng()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Fng);
            FngOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void FngOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, F3.ViewModels.Contact contact);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Fng(F3.ViewModels.Contact contact)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Fng);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "contact", contact);
            FngOverride(callInfo, contact);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void ScheduleOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Schedule()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Schedule);
            ScheduleOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108
