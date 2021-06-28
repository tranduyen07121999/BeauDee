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
    public partial interface ICustomerServiceSv:IBaseService<CustomerService>
    {
    }
    public partial class CustomerServiceSv:BaseService<CustomerService>,ICustomerServiceSv
    {
        public CustomerServiceSv(IUnitOfWork unitOfWork,ICustomerServiceRepository repository):base(unitOfWork,repository){}
    }
}
