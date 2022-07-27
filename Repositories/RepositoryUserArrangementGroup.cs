using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Models;
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
    public class RepositoryUserArrangementGroup : IRepositoryUserArrangementGroup
    {
        private readonly EntityContext _context;
        private readonly IMapper _mapper;
        public RepositoryUserArrangementGroup(EntityContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int userID,int arrangementGroupID)
        {
            var userArrGroup = await _context.UserArrangementGroups.Where(x => x.UserID == userID
                                                                      && x.ArrangementGroupID == arrangementGroupID)
                                                                        .SingleOrDefaultAsync();

            _context.UserArrangementGroups.Remove(userArrGroup);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IUserArrangementGroup> GetByArrangementGroupID(int id,int ararangementGroupID)
        {
            var result= await _context.UserArrangementGroups.Where(x=>x.UserID==id 
                                                            && x.ArrangementGroupID==ararangementGroupID)
                                                                .SingleOrDefaultAsync();

            return result;
        }

        public async Task<List<IUserArrangementGroup>> GetByUserId(int id)
        {
            var result = await _context.UserArrangementGroups.Where(x => x.UserID == id)
                                                    .Include(x=>x.ArrangementGroup)
                                                    .ToListAsync();

            return result.ToList<IUserArrangementGroup>();
        }

        public async Task<bool> Save(IUserArrangementGroup userArrGroup)
        {
            UserArrangementGroup uArrGroup = _mapper.Map<UserArrangementGroup>(userArrGroup);

            _context.UserArrangementGroups.Add(uArrGroup);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
