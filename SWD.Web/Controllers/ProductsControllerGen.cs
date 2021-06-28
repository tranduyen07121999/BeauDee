using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reso.Core.Utilities;
using SWD.Bussiness.Services;
using SWD.Bussiness.ViewModels;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace SWD.Web.Controllers
{
    [ApiController]
    [Route("api/products")]
    public partial class ProductsController : ControllerBase
    {
        private readonly IProductSv _productSv;
        private readonly IServiceSv _serviceSv;
        private readonly IConfigurationProvider _mapper;
        public ProductsController(IProductSv productSv, IMapper mapper)
        {
            _productSv = productSv;
            _mapper = mapper.ConfigurationProvider;
        }
        [HttpGet("all")]
        public IActionResult GetAll([FromQuery] ProductViewModel filter)
        {
            var rs = _productSv.Get().ProjectTo<ProductViewModel>(_mapper)
                    .DynamicFilter<ProductViewModel>(filter); 
            return Ok(rs);

        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(ProductViewModel model)
        {

            //model.ProductId = _productSv.GetAbb();
            //model.ProductId = model.Service.ServieAbb;
            //model.ProductId = model.Service.ServiceAbb;
            //model.Service.ServiceAbb = model.Service.ServiceAbb;
            return Ok(_productSv.Create(model));

            //return CreatedAtAction(nameof(GetById), new { id = entity }, entity);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productSv.Delete(id);
            //delete roi lam gi con entity ma return
            return Ok();

        }
        [HttpPut("id")]
        public IActionResult Update(ProductViewModel model)
        {
            _productSv.Update(model);
            return Ok();
        }

    }

}
