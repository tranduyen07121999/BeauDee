using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWD.Bussiness.Models;
using SWD.Bussiness.Services;
using System.Linq;
namespace Reso_Audit.Controllers
{
    [ApiController]
    [Route("api/artist-slots")]
    public partial class ArtistSlotsController : ControllerBase
    {
        private readonly IArtistSlotSv _artistSlotSv;
        private readonly IConfigurationProvider _mapper;
        public ArtistSlotsController(IArtistSlotSv artistSlotSv,IMapper mapper){
            _artistSlotSv=artistSlotSv;
            _mapper= mapper.ConfigurationProvider;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok( _artistSlotSv.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            return Ok(_artistSlotSv.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(ArtistSlot entity)
        {
            _artistSlotSv.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(int id,ArtistSlot entity)
        {
            _artistSlotSv.Update(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id,ArtistSlot entity)
        {
             _artistSlotSv.Delete(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok( _artistSlotSv.Count());
        }
    }
}
