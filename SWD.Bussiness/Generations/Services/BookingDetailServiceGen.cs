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
    public partial interface IBookingDetailSv:IBaseService<BookingDetail>
    {
    }
    public partial class BookingDetailSv:BaseService<BookingDetail>,IBookingDetailSv
    {
        public BookingDetailSv(IUnitOfWork unitOfWork,IBookingDetailRepository repository):base(unitOfWork,repository){}
    }
}
