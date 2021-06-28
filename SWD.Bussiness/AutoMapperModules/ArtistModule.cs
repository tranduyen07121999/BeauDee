using AutoMapper;
using SWD.Bussiness.Models;
using SWD.Bussiness.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWD.Bussiness.AutoMapperModules
{
  public static class ArtistModule
    {
        public static void ConfigArtistModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Artist, ArtistViewModel>().ReverseMap();
        }
    }
}
