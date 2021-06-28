using AutoMapper;
using Reso.Core.BaseConnect;
using Reso.Core.Custom;
using SWD.Bussiness.Models;
using SWD.Bussiness.Repositories;
using SWD.Bussiness.ViewModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SWD.Bussiness.Services
{
    public partial interface IServiceSv
    {
        Service Create(ServiceViewModel model);
        void Update(ServiceViewModel model);
        void Delete(int id);
    }
    public partial class ServiceSv
    {
        private readonly IConfigurationProvider _mapper;
        //private readonly ICustomerSv __customerSv;
        public ServiceSv(IUnitOfWork unitOfWork, IServiceRepository repository,
            IMapper mapper) : base(unitOfWork, repository)
        {
            _mapper = mapper.ConfigurationProvider;
        }
        public Service Create(ServiceViewModel model)
        {
            var entity = _mapper.CreateMapper().Map<Service>(model);
            Create(entity);
            return entity;
        }
        public void Delete(int id)
        {
            var entity = Get(id);
            if (entity == null) throw new ErrorResponse((int)HttpStatusCode.NotFound, "ID not found");
            Delete(entity);
        }
        public void Update(ServiceViewModel model)
        {
            var entity = _mapper.CreateMapper().Map<Service>(model);
            Update(entity);
        }
    }
}
