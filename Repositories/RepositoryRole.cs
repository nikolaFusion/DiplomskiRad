using Microsoft.EntityFrameworkCore;
using Models.Context;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryRole : IRepositoryRole
    {
        private readonly EntityContext _context;
        public RepositoryRole(EntityContext context)
        {
            _context = context;
        }

        public async Task<int> GetRoleIdByName(string roleName)
        {
            var role= await _context.Roles.Where(x=>x.Name==roleName).FirstOrDefaultAsync();

            return role.RoleID;
        }
    }
}
