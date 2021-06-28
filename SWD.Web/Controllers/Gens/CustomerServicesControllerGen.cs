using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWD.Bussiness.Models;
using SWD.Bussiness.Services;
using System.Linq;
namespace Reso_Audit.Controllers
{
    [ApiController]
    [Route("api/customer-services")]
    public partial class CustomerServicesController : ControllerBase
    {
        private readonly ICustomerServiceSv _customerServiceSv;
        private readonly IConfigurationProvider _mapper;
        public CustomerServicesController(ICustomerServiceSv customerServiceSv,IMapper mapper){
            _customerServiceSv=customerServiceSv;
            _mapper= mapper.ConfigurationProvider;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok( _customerServiceSv.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            return Ok(_customerServiceSv.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(CustomerService entity)
        {
            _customerServiceSv.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(int id,CustomerService entity)
        {
            _customerServiceSv.Update(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id,CustomerService entity)
        {
             _customerServiceSv.Delete(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok( _customerServiceSv.Count());
        }
    }
}
