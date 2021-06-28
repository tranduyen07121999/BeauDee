using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWD.Bussiness.Models;
using SWD.Bussiness.Services;
using System.Linq;
namespace Reso_Audit.Controllers
{
    [ApiController]
    [Route("api/products")]
    public partial class ProductsController : ControllerBase
    {
        private readonly IProductSv _productSv;
        private readonly IConfigurationProvider _mapper;
        public ProductsController(IProductSv productSv,IMapper mapper){
            _productSv=productSv;
            _mapper= mapper.ConfigurationProvider;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok( _productSv.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            return Ok(_productSv.Get(id));
        }
        //[HttpPost]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public IActionResult Create(Product entity)
        //{
        //    _productSv.Create(entity);
        //    return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        //}
        //[HttpPut("{id}")]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public IActionResult Update(int id,Product entity)
        //{
        //    _productSv.Update(entity);
        //    return Ok();
        //}
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id,Product entity)
        //{
        //     _productSv.Delete(entity);
        //    return Ok();
        //}
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok( _productSv.Count());
        }
    }
}
