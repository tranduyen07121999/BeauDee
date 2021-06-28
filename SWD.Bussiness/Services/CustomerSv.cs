using AutoMapper;
using Reso.Core.BaseConnect;
using Reso.Core.Custom;
using SWD.Bussiness.Models;
using SWD.Bussiness.Repositories;
using SWD.Bussiness.ViewModels;
using System.Net;

namespace SWD.Bussiness.Services
{
    public partial interface ICustomerSv
    {
        Customer Create(CustomerViewModel model);
        void Update(CustomerViewModel model);
        void Delete(int id);
    }
    public partial class CustomerSv
    {
        private readonly IConfigurationProvider _mapper;
        //private readonly ICustomerSv __customerSv;
        public CustomerSv(IUnitOfWork unitOfWork, ICustomerRepository repository,
            IMapper mapper) : base(unitOfWork, repository)
        {
            _mapper = mapper.ConfigurationProvider;
        }
        public Customer Create(CustomerViewModel model)
        {
            var entity = _mapper.CreateMapper().Map<Customer>(model);
            Create(entity);
            return entity;
        }
        public void Delete(int id)
        {
            var entity = Get(id);
            if (entity == null) throw new ErrorResponse((int)HttpStatusCode.NotFound, "ID not found");
            Delete(entity);
        }
        public void Update(CustomerViewModel model)
        {
            var entity = _mapper.CreateMapper().Map<Customer>(model);
            Update(entity);
        }
    }
}
