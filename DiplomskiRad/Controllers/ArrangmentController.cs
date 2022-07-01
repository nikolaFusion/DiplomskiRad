using DTOs;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Utils.Interfaces;

namespace DiplomskiRad.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("arrangment")]
    public class ArrangmentController : Controller
    {
        private readonly IArrangmentService _arrangmentService;

        public ArrangmentController(IArrangmentService arrangmentService)
        {
            _arrangmentService = arrangmentService;
        }

        [HttpPost]
        [Route("find-arrangments")]
        public async Task<List<List<IArrangement>>> GetFindingArr([FromBody] FindGroupArrDto model)
        {
            var listOfFindingPlaces =  await _arrangmentService.GetFindingArr(model.TravelPlaceList,model.StartDate,model.EndDate,model.NumberOfPeople);

            return listOfFindingPlaces;              
        }

    }
}
