using System.Web;
using System.Web.Optimization;

namespace firstMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/lib/jquery/jquery.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/lib/bootstrap-rtl/css/bootstrap-rtl.css"));
        }

    }
}
