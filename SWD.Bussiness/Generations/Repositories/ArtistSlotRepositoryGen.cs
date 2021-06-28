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
    public partial interface IArtistSlotRepository :IBaseRepository<ArtistSlot>
    {
    }
    public partial class ArtistSlotRepository :BaseRepository<ArtistSlot>, IArtistSlotRepository
    {
         public ArtistSlotRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

