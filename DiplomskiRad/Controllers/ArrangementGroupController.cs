using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interfaces;

namespace DiplomskiRad.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("arrangment-group")]
    public class ArrangementGroupController : Controller
    {
        private readonly IArrangementGroupService _arrangementGroupService;
        private readonly HttpContext _httpContext;

        public ArrangementGroupController(IArrangementGroupService arrangementGroupService, IHttpContextAccessor contextAccessor)
        {
            _arrangementGroupService = arrangementGroupService;
            _httpContext = contextAccessor.HttpContext;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("save")]
        public async Task<bool> SaveArrangementGroup([FromBody] ArrangementGroupDto arrangementGroup)
        {
            var userID = _httpContext.User.Claims.FirstOrDefault().Value;

            await _arrangementGroupService.Save(arrangementGroup.Price,userID, arrangementGroup.ArrangementsIDs);

            return true;
        }

        [HttpDelete]
        [Authorize]
        [Route("{arrangementGroupID}")]
        public async Task<bool> DeleteArrangementGroup(string arrangementGroupID)
        {
            var userID = _httpContext.User.Claims.FirstOrDefault().Value;

            await _arrangementGroupService.Delete(arrangementGroupID, userID);

            return true;
        }
    }
}
