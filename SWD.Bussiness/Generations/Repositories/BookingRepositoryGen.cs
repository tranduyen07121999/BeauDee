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
    public partial interface IBookingRepository :IBaseRepository<Booking>
    {
    }
    public partial class BookingRepository :BaseRepository<Booking>, IBookingRepository
    {
         public BookingRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

