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
    public class RepositoryArrangment : IRepositoryArrangment
    {
        private readonly EntityContext _context;
        public RepositoryArrangment(EntityContext context)
        {
            _context = context;
        }

        public async Task<List<IArrangement>> FindAllByPlaceId(int idTravelPlace)
        {
            var result = await _context.Arrangements.Where(x => x.TravelPlaceID == idTravelPlace)
                                                    .Include(x=>x.TravelPlace)
                                                    .Include(x=>x.TravelCompany)
                                                    .ToListAsync();

            return result.ToList<IArrangement>();
        }

        public async Task<List<IArrangement>> FindByFilter(int TravelPlaceID, int numberOfPlace,
            DateTime startDate, DateTime endDate, double downPrice, double upPrice)
        {
         
                var result = await _context.Arrangements.Where(x => x.TravelPlaceID == TravelPlaceID
                                                                && x.SeatsInArrangement > numberOfPlace
                                                                && x.Price >= downPrice
                                                                && x.Price <= upPrice
                                                                && x.DateStart<=endDate
                                                                && x.DateStart>=startDate)
                                                                    .ToListAsync();

                return result.ToList<IArrangement>();
        }

        public  async Task<List<IArrangement>> GetBeforeEndDate(int place, DateTime startDate, DateTime? endDate, int numberOfPeople, bool last)
        {
            if (last)
            {
                var res = await _context.Arrangements.Where(x => x.TravelPlaceID == place
                                                                        && x.DateStart.Day == startDate.Day
                                                                         && x.DateStart.Month == startDate.Month
                                                                          && x.DateStart.Year == startDate.Year
                                                                        && x.SeatsInArrangement >= numberOfPeople)
                                                                              .Include(x=>x.TravelPlace)
                                                                              .Include(x=>x.TravelCompany)
                                                                              .ToListAsync();
                return res.ToList<IArrangement>();
            }

            var result = await _context.Arrangements.Where(x => x.TravelPlaceID == place
                                                          && x.DateStart.Day == startDate.Day
                                                           && x.DateStart.Month == startDate.Month
                                                            && x.DateStart.Year == startDate.Year
                                                           && x.DateEnd <= endDate
                                                          && x.SeatsInArrangement >= numberOfPeople)
                                                                  .Include(x => x.TravelPlace)
                                                                  .Include(x => x.TravelCompany)
                                                                .ToListAsync();
            return result.ToList<IArrangement>();
        }

        public async Task<IArrangement> GetByID(int id)
        {
            var result = await _context.Arrangements.Where(x => x.ArrangementID == id)
                                                     .Include(x=>x.TravelPlace)
                                                     .Include(x=>x.TravelCompany)
                                                     .SingleOrDefaultAsync();

            return result;
        }
    }
}
