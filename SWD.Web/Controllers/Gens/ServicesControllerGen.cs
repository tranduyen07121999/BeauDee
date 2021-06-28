using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWD.Bussiness.Models;
using SWD.Bussiness.Services;
using System.Linq;
namespace Reso_Audit.Controllers
{
    [ApiController]
    [Route("api/services")]
    public partial class ServicesController : ControllerBase
    {
        private readonly IServiceSv _serviceSv;
        private readonly IConfigurationProvider _mapper;
        public ServicesController(IServiceSv serviceSv,IMapper mapper){
            _serviceSv=serviceSv;
            _mapper= mapper.ConfigurationProvider;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok( _serviceSv.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            return Ok(_serviceSv.Get(id));
        }
        //[HttpPost]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public IActionResult Create(Service entity)
        //{
        //    _serviceSv.Create(entity);
        //    return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        //}
        //[HttpPut("{id}")]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public IActionResult Update(int id,Service entity)
        //{
        //    _serviceSv.Update(entity);
        //    return Ok();
        //}
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id,Service entity)
        //{
        //     _serviceSv.Delete(entity);
        //    return Ok();
        //}
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok( _serviceSv.Count());
        }
    }
}
