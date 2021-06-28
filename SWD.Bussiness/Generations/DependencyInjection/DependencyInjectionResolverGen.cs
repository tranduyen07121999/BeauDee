
/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////

using SWD.Bussiness.Models;
using Microsoft.Extensions.DependencyInjection;
using SWD.Bussiness.Services;
using SWD.Bussiness.Repositories;
using Microsoft.EntityFrameworkCore;
using Reso.Core.BaseConnect;
namespace SWD.Bussiness.Commons
{
    public static class DependencyInjectionResolverGen
    {
        public static void InitializerDI(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DbContext, BeauDeeContext>();
        
            services.AddScoped<IArtistSv, ArtistSv>();
            services.AddScoped<IArtistRepository, ArtistRepository>();
        
            services.AddScoped<IArtistServiceSv, ArtistServiceSv>();
            services.AddScoped<IArtistServiceRepository, ArtistServiceRepository>();
        
            services.AddScoped<IArtistSlotSv, ArtistSlotSv>();
            services.AddScoped<IArtistSlotRepository, ArtistSlotRepository>();
        
            services.AddScoped<IBookingSv, BookingSv>();
            services.AddScoped<IBookingRepository, BookingRepository>();
        
            services.AddScoped<IBookingDetailSv, BookingDetailSv>();
            services.AddScoped<IBookingDetailRepository, BookingDetailRepository>();
        
            services.AddScoped<ICustomerSv, CustomerSv>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        
            services.AddScoped<ICustomerServiceSv, CustomerServiceSv>();
            services.AddScoped<ICustomerServiceRepository, CustomerServiceRepository>();
        
            services.AddScoped<IProductSv, ProductSv>();
            services.AddScoped<IProductRepository, ProductRepository>();
        
            services.AddScoped<IProductArtistServiceSv, ProductArtistServiceSv>();
            services.AddScoped<IProductArtistServiceRepository, ProductArtistServiceRepository>();
        
            services.AddScoped<IServiceSv, ServiceSv>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
        }
    }
}
