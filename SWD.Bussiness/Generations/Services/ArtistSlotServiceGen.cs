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
    public partial interface IArtistSlotSv:IBaseService<ArtistSlot>
    {
    }
    public partial class ArtistSlotSv:BaseService<ArtistSlot>,IArtistSlotSv
    {
        public ArtistSlotSv(IUnitOfWork unitOfWork,IArtistSlotRepository repository):base(unitOfWork,repository){}
    }
}
