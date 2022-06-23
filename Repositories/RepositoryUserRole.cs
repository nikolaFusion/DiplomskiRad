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
        public RepositoryUserRole(EntityContext context)
        {
            _context = context;
        }
        public async Task<bool> AddUserRole(IUserRole userRole)
        {
            _context.UserRoles.AddAsync(new UserRole(userRole));

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {

            }
            return true;
        }
    }
}
