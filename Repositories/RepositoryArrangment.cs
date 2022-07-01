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

        public  async Task<List<IArrangement>> GetBeforeEndDate(int place, DateTime startDate, DateTime? endDate, int numberOfPeople, bool last)
        {
            if (last)
            {
                var res = await _context.Arrangements.Where(x => x.TravelPlaceID == place
                                                                        && x.DateStart.Day == startDate.Day
                                                                         && x.DateStart.Month == startDate.Month
                                                                          && x.DateStart.Year == startDate.Year
                                                                        && x.SeatsInArrangement >= numberOfPeople)
                                                                              .ToListAsync();
                return res.ToList<IArrangement>();
            }

            var result = await _context.Arrangements.Where(x => x.TravelPlaceID == place
                                                          && x.DateStart.Day == startDate.Day
                                                           && x.DateStart.Month == startDate.Month
                                                            && x.DateStart.Year == startDate.Year
                                                           && x.DateEnd <= endDate
                                                          && x.SeatsInArrangement >= numberOfPeople)
                                                                .ToListAsync();
            return result.ToList<IArrangement>();
        }

    }
}
