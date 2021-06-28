using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reso.Core.Extension;
using SWD.Bussiness.Models;
using SWD.Web.App_Start;
using SWD.Web.Handlers;

namespace SWD.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureFilter<ErrorHandlingFilter>();
            services.JsonFormatConfig();
            services.ConfigureSwagger();
            //services.AddDbContext<BeauDeeContext>(options =>
            //options.UseSqlServer(Configuration["ConnectionStrings:BeauDee"]), ServiceLifetime.Singleton);
            services.AddDbContext<BeauDeeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BeauDee")));
            services.ConfigureAutoMapper();
            services.ConfigureDI();
            services.ConfigureServiceWorkers();
            services.ConfigDataProtection();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            app.ConfigureErrorHandler(env);
            app.UseRouting();
            app.ConfigureAuthor();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.ConfigureSwagger(provider);
        }
    }
}
