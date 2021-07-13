﻿using HelloWorldRepository.BusinessLayer;
using HelloWorldRepository.DataAccessLayer;
using HelloWorldWebAPI.App_Start;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HelloWorldWebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new Container();
            //container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Register<IHelloWorldDataAccessLayer, HelloWorldDataAccessLayer>();
            container.Register<IHelloWorldBusinessLayer, HelloWorldBusinessLayer>();

            // container.Verify();
        
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
           
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorDependencyResolver(container);
           
        }
    }
}
