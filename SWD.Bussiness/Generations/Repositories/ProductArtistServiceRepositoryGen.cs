/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////

using Microsoft.EntityFrameworkCore;
using Reso.Core.BaseConnect;
using SWD.Bussiness.Models;
namespace SWD.Bussiness.Repositories
{
    public partial interface IProductArtistServiceRepository :IBaseRepository<ProductArtistService>
    {
    }
    public partial class ProductArtistServiceRepository :BaseRepository<ProductArtistService>, IProductArtistServiceRepository
    {
         public ProductArtistServiceRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

