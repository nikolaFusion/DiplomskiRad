using AutoMapper;
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
    public class RepositoryUserRole : IRepositoryUserRole
    {
        private readonly EntityContext _context;
        private readonly IMapper _mapper;
        public RepositoryUserRole(EntityContext context,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<bool> AddUserRole(IUserRole userRole)
        {
            _context.UserRoles.AddAsync(_mapper.Map<UserRole>(userRole));

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
