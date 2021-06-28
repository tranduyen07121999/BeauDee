using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWD.Bussiness.Models;
using SWD.Bussiness.Services;
using System.Linq;
namespace Reso_Audit.Controllers
{
    [ApiController]
    [Route("api/artist-services")]
    public partial class ArtistServicesController : ControllerBase
    {
        private readonly IArtistServiceSv _artistServiceSv;
        private readonly IConfigurationProvider _mapper;
        public ArtistServicesController(IArtistServiceSv artistServiceSv,IMapper mapper){
            _artistServiceSv=artistServiceSv;
            _mapper= mapper.ConfigurationProvider;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok( _artistServiceSv.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int? id)
        {
            return Ok(_artistServiceSv.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(ArtistService entity)
        {
            _artistServiceSv.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(int? id,ArtistService entity)
        {
            _artistServiceSv.Update(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int? id,ArtistService entity)
        {
             _artistServiceSv.Delete(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok( _artistServiceSv.Count());
        }
    }
}
