using AutoMapper;
using Reso.Core.BaseConnect;
using Reso.Core.Custom;
using SWD.Bussiness.Models;
using SWD.Bussiness.Repositories;
using SWD.Bussiness.ViewModels;
using System;
using System.Net;

namespace SWD.Bussiness.Services
{
    public partial interface IProductSv
    {
        Product Create(ProductViewModel model);
        void Delete(int id);
        void Update(ProductViewModel model);

    }
    public partial class ProductSv
    {
        private readonly IConfigurationProvider _mapper;
        private readonly ICustomerSv _customerSv;
        private readonly IProductSv _productSv;
        public ProductSv(IUnitOfWork unitOfWork, IProductRepository repository,
            IMapper mapper) : base(unitOfWork, repository)
        {
            _mapper = mapper.ConfigurationProvider;
        }
        
        public Product Create(ProductViewModel model)
        {
            var entity = _mapper.CreateMapper().Map<Product>(model);
            Create(entity);
            
            return entity;

            //  linq , auto mapper,dependency injection
            //var dbcontext = new Bussiness.Models.BeauDeeContext();
            //var artists = from a in dbcontext.Artist
            //              where a.
            //              select a

            //Get(g => g.ArtistName == "" && g.ArtistId == 1);

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
        public void Update(ProductViewModel model)
        {
            var entity = _mapper.CreateMapper().Map<ProductViewModel>(model);
            
            //check co ton tai k neu co thi update k thi throw exception
            //if (entity == null) throw new errorresponse((int)httpstatuscode.notfound, "ghi loi ra neu muon")
            //get(g => g.artistid == 1);
            Update(entity);
        }

    }
}
