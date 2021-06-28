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
    public partial interface IArtistRepository :IBaseRepository<Artist>
    {
    }
    public partial class ArtistRepository :BaseRepository<Artist>, IArtistRepository
    {
         public ArtistRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

