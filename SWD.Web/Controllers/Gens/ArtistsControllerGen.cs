using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWD.Bussiness.Models;
using SWD.Bussiness.Services;
using System.Linq;
namespace Reso_Audit.Controllers
{
    [ApiController]
    [Route("api/artists")]
    public partial class ArtistsController : ControllerBase
    {
        private readonly IArtistSv _artistSv;
        private readonly IConfigurationProvider _mapper;
        public ArtistsController(IArtistSv artistSv,IMapper mapper){
            _artistSv=artistSv;
            _mapper= mapper.ConfigurationProvider;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok( _artistSv.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            return Ok(_artistSv.Get(id));
        }
       
      
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok( _artistSv.Count());
        }
    }
}
