using System.Web;
using System.Web.Optimization;

namespace project_CAN
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Script Bundle Example
            // bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            // Bootstrap Bundle Example
            // bundles.Add(new Bundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            // CSS Bundle Example
            // bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            // Script Bundles
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery/dist/jquery.min.js",
                "~/Scripts/jquery-ui/jquery-ui.min.js", "~/Scripts/slimScroll/jquery.slimscroll.min.js",
                "~/Scripts/jquery-flot/jquery.flot.js", "~/Scripts/jquery-flot/jquery.flot.resize.js",
                "~/Scripts/jquery-flot/jquery.flot.pie.js", "~/Scripts/jquery.flot.spline/index.js",
                "~/Scripts/homer.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/iCheck").Include("~/Scripts/iCheck/icheck.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/sparkline").Include("~/Scripts/sparkline/index.js"));
            bundles.Add(new ScriptBundle("~/bundles/peity").Include("~/Scripts/peity/jquery.peity.min.js"));

            // Bootstrap Bundles
            bundles.Add(new Bundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap/dist/js/bootstrap.min.js"));

            // CSS Bundles
            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/style.css", "~/Content/font-awesome.css",
                     "~/Content/helper.css", "~/Content/metisMenu.css",
                     "~/Content/pe-icon-7-stroke.css", "~/Content/animate.css",
                     "~/Content/bootstrap.css"));
        }
    }
}
