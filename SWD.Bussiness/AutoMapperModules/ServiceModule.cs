using AutoMapper;
using SWD.Bussiness.Models;
using SWD.Bussiness.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWD.Bussiness.AutoMapperModules
{
    public static class ServiceModule
    {
        public static void ConfigServiceModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Service, ServiceViewModel>().ReverseMap();
        }
    }
}
