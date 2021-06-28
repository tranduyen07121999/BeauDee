using AutoMapper;
using Reso.Core.BaseConnect;
using Reso.Core.Custom;
using SWD.Bussiness.Models;
using SWD.Bussiness.Repositories;
using SWD.Bussiness.ViewModels;
using System.Net;

namespace SWD.Bussiness.Services
{
    public partial interface IArtistSv
    {
        Artist Create(ArtistViewModel model);
        void Delete(int id);
        void Update(ArtistViewModel model);
    }
    public partial class ArtistSv
    {
        private readonly IConfigurationProvider _mapper;
        private readonly ICustomerSv _customerSv;
        public ArtistSv(IUnitOfWork unitOfWork, IArtistRepository repository,
            IMapper mapper, ICustomerSv customerSv) : base(unitOfWork, repository)
        {
            _mapper = mapper.ConfigurationProvider;
            _customerSv = customerSv;
        }

        public Artist Create(ArtistViewModel model)
        {
            var entity = _mapper.CreateMapper().Map<Artist>(model);

            //  linq , auto mapper,dependency injection
            //var dbcontext = new Bussiness.Models.BeauDeeContext();
            //var artists = from a in dbcontext.Artist
            //              where a.
            //              select a

            //Get(g => g.ArtistName == "" && g.ArtistId == 1);
            Create(entity);
            return entity;
        }
        public void Delete(int id)
        {
            // cai nay anh chua viet delete theo Id
            // xiu anh cap nhat lai nuget

            var entity = Get(id);
            //check co ton tai k neu co thi delete k thi throw exception
            if (entity == null) throw new ErrorResponse((int)HttpStatusCode.NotFound, "ID not found");
            Delete(entity);
        }
        public void Update(ArtistViewModel model)
        {
            var entity = _mapper.CreateMapper().Map<Artist>(model);
            //check co ton tai k neu co thi update k thi throw exception
            //if (entity == null) throw new ErrorResponse((int)HttpStatusCode.NotFound, "ghi loi ra neu muon")
            //Get(g => g.ArtistId == 1);
            Update(entity);
        }
    }
}
