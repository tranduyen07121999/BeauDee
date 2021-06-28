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
    public partial interface IArtistServiceRepository :IBaseRepository<ArtistService>
    {
    }
    public partial class ArtistServiceRepository :BaseRepository<ArtistService>, IArtistServiceRepository
    {
         public ArtistServiceRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

