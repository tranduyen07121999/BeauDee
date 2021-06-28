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
    public partial interface IArtistServiceSv:IBaseService<ArtistService>
    {
    }
    public partial class ArtistServiceSv:BaseService<ArtistService>,IArtistServiceSv
    {
        public ArtistServiceSv(IUnitOfWork unitOfWork,IArtistServiceRepository repository):base(unitOfWork,repository){}
    }
}
