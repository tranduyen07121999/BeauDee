using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SWD.Bussiness.AutoMapperModules;

namespace SWD.Web.App_Start
{
    public static class AutoMapperConfig
    {
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.ConfigArtistModule();
                mc.ConfigProductModule();
                mc.ConfigCustomerModule();
                mc.ConfigServiceModule();

            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
