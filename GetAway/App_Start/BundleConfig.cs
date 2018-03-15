using System.Web;
using System.Web.Optimization;

namespace GetAway
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapClientJquery").Include(
                    "~/Scripts/js/jquery.min.js",
                    "~/Scripts/js/jquery.easing.1.3.js",
                    "~/Scripts/js/bootstrap.min.js",
                    "~/Scripts/js/jquery.waypoints.min.js",
                    "~/Scripts/js/sticky.js",
                    "~/Scripts/js/jquery.stellar.min.js",
                    "~/Scripts/js/hoverIntent.js",
                    "~/Scripts/js/superfish.js",
                    "~/Scripts/js/jquery.magnific-popup.min.js",
                    "~/Scripts/js/magnific-popup-options.js",
                    "~/Scripts/js/bootstrap-datepicker.min.js",
                    "~/Scripts/js/classie.js",
                    "~/Scripts/js/selectFx.js",
                    "~/Scripts/js/main.js",
                    "~/Scripts/js/modernizr-2.6.2.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    
                    "~/Content/css/animate.css",
                    "~/Content/css/icomoon.css",
                    "~/Content/css/bootstrap.css",
                    "~/Content/css/superfish.css",
                    "~/Content/css/magnific-popup.css",
                    "~/Content/css/bootstrap-datepicker.min.css",
                    "~/Content/css/cs-select.css",
                    "~/Content/css/cs-skin-border.css",
                    "~/Content/css/style.css",
                    "~/Content/css/font.css"));
        }
    }
}
