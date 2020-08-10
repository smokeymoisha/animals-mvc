using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Animals_MVC.Autofac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<AnimalsRepository>().As<IAnimalsRepository>();
            builder.RegisterType<AnimalsManager>().As<IAnimalsManager>();
            builder.RegisterType<JsonConverter>().As<IJsonConverter>();

            builder.RegisterModule<MapperModule>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}