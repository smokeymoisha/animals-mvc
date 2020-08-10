using Animals_MVC.Models;
using Autofac;
using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_MVC.Autofac
{
    public class MapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cat, CatModel>();
                cfg.CreateMap<Home, HomeModel>();
                cfg.CreateMap<CatModel, Cat>();
                cfg.CreateMap<HomeModel, Home>();

                cfg.CreateMap<CatViewModel, CatModel>();
                cfg.CreateMap<HomeViewModel, HomeModel>();
                cfg.CreateMap<CatModel, CatViewModel>();
                cfg.CreateMap<HomeModel, HomeViewModel>();
            }))
            .AsSelf()
            .SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
        }
    }
}