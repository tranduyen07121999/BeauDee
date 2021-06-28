using Microsoft.Extensions.DependencyInjection;
using SWD.Bussiness.Commons;
using SWD.Bussiness.ThirdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWD.Web.App_Start
{
    public static class DependencyInjectionResolver
    {
        public static void ConfigureDI(this IServiceCollection services)
        {
            services.InitializerDI();
            services.AddSingleton<IZaloClient, ZaloClient>();

        }
    }
}
