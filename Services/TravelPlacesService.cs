using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.ErrorModels;
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

        public async Task<ITravelPlace> FindById(string id)
        {
            int idNum;

            try
            {
                if(!Int32.TryParse(id, out idNum))
                {
                    throw new BadRequestError($"This id:{id} is not number");
                }

                var result = await _repoTravelPlace.FindByID(idNum);
                return result;
            }
            catch (Exception ex)
            {
                throw new BadRequestError($"Cannot return travel places with id:{id}");
            }
        }

        public async Task<List<ITravelPlace>> FindByValue(string searchValue)
        {
            if(searchValue == null)
            {
                var list = await GetAll();

            }

            try
            {
                var result = await _repoTravelPlace.FindByValue(searchValue);
                return result;
            }
            catch (Exception ex)
            {
                throw new BadRequestError("Cannot return all travel places");
            }
        }

        public async Task<List<ITravelPlace>> GetAll()
        {
            try
            {
                var result = await _repoTravelPlace.GetAll();
                return result;
            }
            catch (Exception ex)
            {
                throw new BadRequestError("Cannot return all travel places");
            }
        }
    }
}
