using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.Optimization;

namespace TDC
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            var razorEngine = ViewEngines.Engines.OfType<RazorViewEngine>().FirstOrDefault();
            razorEngine.ViewLocationFormats =
                razorEngine.ViewLocationFormats.Concat(new string[] {
                    "~/Products/Views/{0}.cshtml"
                }).ToArray();

            // Add /MyVeryOwnPartialFolder/ folder to the default location scheme for PARTIAL Views
            razorEngine.PartialViewLocationFormats =
                razorEngine.PartialViewLocationFormats.Concat(new string[] {
            "~/MyVeryOwnPartialFolder/{0}.cshtml"
                    // add other folders here (if any)
                }).ToArray();

        }
    }
}