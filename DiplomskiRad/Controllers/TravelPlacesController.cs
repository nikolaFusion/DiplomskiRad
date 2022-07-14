using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Utils.Interfaces;

namespace DiplomskiRad.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("travel-places")]
    public class TravelPlacesController : ControllerBase
    {
        private readonly ITravelPlacesService _travelService;

        public TravelPlacesController(ITravelPlacesService travelService)
        {
            _travelService = travelService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TravelPlacesDto>>> GetAll()
        {
            var result = await _travelService.GetAll();

            var list = result.Select(x => new TravelPlacesDto(x)).ToList();

            return list;
        }

        [HttpGet]
        [Route("find-place/{searchValue}")]
        public async Task<ActionResult<List<TravelPlacesDto>>> GetFindPlaces(string searchValue)
        {
            var result = await _travelService.FindByValue(searchValue);

            var list = result.Select(x => new TravelPlacesDto(x)).ToList();

            return list;
        }
    }
}

