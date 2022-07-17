using AutoMapper;
using Models;
using Models.Context;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Repositories
{
    public class RepositoryArrangementGroup : IRepositoryArranegementGroup
    {
        private readonly EntityContext _context;
        private readonly IMapper _mapper;

        public RepositoryArrangementGroup(EntityContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int arrangementGroupID)
        {
            var arrGroup =await _context.ArrangementGroups.Where(x => x.ArrangementGroupID == arrangementGroupID)
                                                                    .SingleOrDefaultAsync();

            _context.ArrangementGroups.Remove(arrGroup);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IArrangementGroup> GetByID(int arrangementGroupID)
        {
            var result = await _context.ArrangementGroups.Where(x =>x.ArrangementGroupID == arrangementGroupID).FirstOrDefaultAsync();
            return result;
        }

        public async Task<int> GetLastID()
        {
            var result = await _context.ArrangementGroups.OrderByDescending(u => u.ArrangementGroupID).FirstOrDefaultAsync();

            if (result == null)
            {
                return 0;
            }

            return result.ArrangementGroupID;
        }

        public async Task<bool> Save(IArrangementGroup arrGroup)
        {
            ArrangementGroup arrangementGroup = _mapper.Map<ArrangementGroup>(arrGroup);

             _context.ArrangementGroups.Add(arrangementGroup);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
