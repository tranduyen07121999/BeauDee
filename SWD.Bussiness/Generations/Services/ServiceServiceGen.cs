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
    public partial interface IServiceSv:IBaseService<Service>
    {
    }
    public partial class ServiceSv:BaseService<Service>,IServiceSv
    {
        public ServiceSv(IUnitOfWork unitOfWork,IServiceRepository repository):base(unitOfWork,repository){}
    }
}
