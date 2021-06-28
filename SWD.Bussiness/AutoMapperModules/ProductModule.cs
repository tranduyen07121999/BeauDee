using AutoMapper;
using SWD.Bussiness.Models;
using SWD.Bussiness.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWD.Bussiness.AutoMapperModules
{
    public static class ProductModule
    {
        public static void ConfigProductModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Product, ProductViewModel>()
                //.ForMember(des => des.Service, opt => opt.MapFrom(src => src.Service))
                .ReverseMap();
            //mc.CreateMap<Service, ServiceViewModel>()
            //   .ReverseMap();
        }
    }
}
