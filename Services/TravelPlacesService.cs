using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services
{
    public class TravelPlacesService : ITravelPlacesService
    {
        private readonly IRepositoryTravelPlaces _repoTravelPlace;
        public TravelPlacesService( IRepositoryTravelPlaces repoTravelPlace)
        {
            _repoTravelPlace = repoTravelPlace;
        }
        public async Task<List<ITravelPlace>> GetAll()
        {
            var result = await _repoTravelPlace.GetAll();
            return result;
        }
    }
}
