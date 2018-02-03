using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using TheMVCRequestLifeCycle.Models;

namespace TheMVCRequestLifeCycle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            var builder= new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<Logger>().As<ILogger>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


            ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory());


            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }
    }
}
