using AutoMapper;
using SWD.Bussiness.Models;
using SWD.Bussiness.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWD.Bussiness.AutoMapperModules
{
    public static class CustomerModule
    {
        public static void ConfigCustomerModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Customer, CustomerViewModel>().ReverseMap();
        }
    }
}
