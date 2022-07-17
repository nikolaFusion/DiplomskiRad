﻿using DTOs;
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
        public async Task<List<IArrangementGroup>> GetFindingArr([FromBody] FindGroupArrDto model)
        {
            var start = new DateTime(model.StartDate.Year, model.StartDate.Month, model.StartDate.Day+1);
            var end = new DateTime(model.EndDate.Year, model.EndDate.Month, model.EndDate.Day+1);

            var listOfFindingPlaces =  await _arrangmentService.GetFindingArr(model.TravelPlaceList,start,end,model.NumberOfPeople);

            return listOfFindingPlaces;              
        }

        [HttpPost]
        [Route("filter-arrangement")]
        public async Task<List<IArrangement>> GetArrByFilter([FromBody] ArrangementFilterDto filter)
        {
            var result = await _arrangmentService.GetArrangementByFilter(filter.TravelPlaceID,
                filter.numberOfPlace,filter.StartDate,filter.EndDate,filter.downPrice,filter.upPrice);

            return result;
        }

    }
}
