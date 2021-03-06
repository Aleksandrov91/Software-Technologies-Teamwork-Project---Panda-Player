﻿using System.Web.Optimization;

namespace Panda_Player
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/modalFunction").Include(
                        "~/Scripts/modalFunc.js"));

            bundles.Add(new ScriptBundle("~/bundles/paging").Include(
                        "~/Scripts/paging.js"));

            bundles.Add(new ScriptBundle("~/bundles/player").Include(
                        "~/Scripts/Player/player.js"));

            bundles.Add(new ScriptBundle("~/bundles/playlistparser").Include(
                        "~/Scripts/Player/playlistparser.js"));

            bundles.Add(new ScriptBundle("~/bundles/wavesurfer").Include(
                        "~/Scripts/Player/wavesurfer.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/wavesurfer.playlist").Include(
                        "~/Scripts/Player/wavesurfer.playlist.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-datetimepicker").Include(
                "~/Scripts/moment.js",
                "~/Scripts/bootstrap-datetimepicker.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-datetimepicker").Include(
                "~/Content/bootstrap-datetimepicker.min.css"));
        }
    }
}
