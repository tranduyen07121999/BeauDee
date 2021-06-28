using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reso.Core.Utilities;
using SWD.Bussiness.Models;
using SWD.Bussiness.Services;
using SWD.Bussiness.ViewModels;

namespace SWD.Web.Controllers
{


    [ApiController]
    [Route("api/services")]
    public partial class ServicesController : ControllerBase
    {
        private readonly IServiceSv _serviceSv;
        private readonly IConfigurationProvider _mapper;
        public ServicesController(IServiceSv serviceSv, IMapper mapper)
        {
            _serviceSv = serviceSv;
            _mapper = mapper.ConfigurationProvider;
        }
        [HttpGet("all")]
        public IActionResult GetAll([FromQuery] ServiceViewModel filter)
        {
            var rs = _serviceSv.Get().ProjectTo<ServiceViewModel>(_mapper)
                    .DynamicFilter<ServiceViewModel>(filter);

            return Ok(rs);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(ServiceViewModel model)
        {

            return Ok(_serviceSv.Create(model));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serviceSv.Delete(id);
            return Ok();

        }
        [HttpPut]
        public IActionResult Update(ServiceViewModel model)
        {
            _serviceSv.Update(model);
            return Ok();
        }

    }
}

