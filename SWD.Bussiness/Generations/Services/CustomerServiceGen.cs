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
    public partial interface ICustomerSv:IBaseService<Customer>
    {
    }
    public partial class CustomerSv:BaseService<Customer>,ICustomerSv
    {
        public CustomerSv(IUnitOfWork unitOfWork,ICustomerRepository repository):base(unitOfWork,repository){}
    }
}
