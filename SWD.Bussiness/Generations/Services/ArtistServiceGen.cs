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
    public partial interface IArtistSv:IBaseService<Artist>
    {
    }
    public partial class ArtistSv:BaseService<Artist>,IArtistSv
    {
        public ArtistSv(IUnitOfWork unitOfWork,IArtistRepository repository):base(unitOfWork,repository){}
    }
}
