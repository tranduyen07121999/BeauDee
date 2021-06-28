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
    public partial interface IBookingDetailRepository :IBaseRepository<BookingDetail>
    {
    }
    public partial class BookingDetailRepository :BaseRepository<BookingDetail>, IBookingDetailRepository
    {
         public BookingDetailRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

