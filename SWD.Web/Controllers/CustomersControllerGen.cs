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
    [Route("api/customers")]
    public partial class CustomersController : ControllerBase
    {
        private readonly ICustomerSv _customerSv;
        private readonly IConfigurationProvider _mapper;
        public CustomersController(ICustomerSv customerSv, IMapper mapper)
        {
            _customerSv = customerSv;
            _mapper = mapper.ConfigurationProvider;
        }
        [HttpGet("all")]
        public IActionResult GetAll([FromQuery] CustomerViewModel filter)
        {
            var rs = _customerSv.Get().ProjectTo<CustomerViewModel>(_mapper)
                    .DynamicFilter<CustomerViewModel>(filter);
            return Ok(rs);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(CustomerViewModel model)
        {

            return Ok(_customerSv.Create(model));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _customerSv.Delete(id);
            return Ok();

        }
        [HttpPut]
        public IActionResult Update(CustomerViewModel model)
        {
            _customerSv.Update(model);
            return Ok();
        }

    }
}
