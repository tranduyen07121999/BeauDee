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
    [Route("api/artists")]
    public partial class ArtistsController : ControllerBase
    {
        private readonly IArtistSv _artistSv;
        private readonly IConfigurationProvider _mapper;
        public ArtistsController(IArtistSv artistSv, IMapper mapper)
        {
            _artistSv = artistSv;
            _mapper = mapper.ConfigurationProvider;
        }
        [HttpGet("all")]
        public IActionResult GetAll([FromQuery] ArtistViewModel filter)
        {
            var rs = _artistSv.Get().ProjectTo<ArtistViewModel>(_mapper)
                    .DynamicFilter<ArtistViewModel>(filter);
            return Ok(rs);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(ArtistViewModel model)
        {
           
            return Ok(_artistSv.Create(model));
            //return CreatedAtAction(nameof(GetById), new { id = entity }, entity);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _artistSv.Delete(id);
            //delete roi lam gi con entity ma return
            return Ok();

        }
        [HttpPut]
        public IActionResult Update(ArtistViewModel model)
        {
            _artistSv.Update(model);
            return Ok();
        }

    }
}
