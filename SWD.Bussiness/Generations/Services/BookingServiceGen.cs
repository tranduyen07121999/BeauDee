/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////
namespace SWD.Bussiness.Services
{
    using Reso.Core.BaseConnect;
    using SWD.Bussiness.Models;
    using SWD.Bussiness.Repositories;
    public partial interface IBookingSv:IBaseService<Booking>
    {
    }
    public partial class BookingSv:BaseService<Booking>,IBookingSv
    {
        public BookingSv(IUnitOfWork unitOfWork,IBookingRepository repository):base(unitOfWork,repository){}
    }
}
