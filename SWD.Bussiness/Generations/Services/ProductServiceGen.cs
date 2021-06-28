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
    public partial interface IProductSv:IBaseService<Product>
    {
    }
    public partial class ProductSv:BaseService<Product>,IProductSv
    {
        public ProductSv(IUnitOfWork unitOfWork,IProductRepository repository):base(unitOfWork,repository){}
    }
}
