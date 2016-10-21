using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Episerver9.Business
{
    [InitializableModule]
    public class BundleConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if(context.HostType == HostType.WebApplication)
            {
                RegisterBundles(BundleTable.Bundles);
            }
        }

        public void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery.js").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap.js").Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"));
            bundles.Add(new StyleBundle("~/Content/style.css").Include("~/Content/bootstrap.css"));

            BundleTable.EnableOptimizations = false;
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}