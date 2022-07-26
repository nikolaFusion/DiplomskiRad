using Microsoft.EntityFrameworkCore;
using Models.Context;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Repositories
{
    public class RepositoryTravelPlaces : IRepositoryTravelPlaces
    {
        private readonly EntityContext _context;

        public RepositoryTravelPlaces(EntityContext context)
        {
            _context = context;
        }

        public async Task<ITravelPlace> FindByID(int id)
        {
            var result = await _context.TravelPlaces.Where(x => x.TravelPlaceID==id).SingleOrDefaultAsync();
            return result;
        }

        public async Task<List<ITravelPlace>> FindByValue(string? searchValue)
        {
            var result = await _context.TravelPlaces.Where(x => x.Name.ToLower().Contains(searchValue.ToLower()) || x.Country.ToLower().Contains(searchValue.ToLower())).ToListAsync();
            return result.ToList<ITravelPlace>(); 
        }

        public async Task<List<ITravelPlace>> GetAll()
        {
            var result= await _context.TravelPlaces.ToListAsync();
            return result.ToList<ITravelPlace>();
        }
            
    }
}
