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
    public partial interface IProductArtistServiceSv:IBaseService<ProductArtistService>
    {
    }
    public partial class ProductArtistServiceSv:BaseService<ProductArtistService>,IProductArtistServiceSv
    {
        public ProductArtistServiceSv(IUnitOfWork unitOfWork,IProductArtistServiceRepository repository):base(unitOfWork,repository){}
    }
}
