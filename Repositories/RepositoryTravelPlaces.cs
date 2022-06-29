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
        public async Task<List<ITravelPlace>> GetAll()
        {
            var result= await _context.TravelPlaces.ToListAsync();
            return result.ToList<ITravelPlace>();
        }
            
    }
}
