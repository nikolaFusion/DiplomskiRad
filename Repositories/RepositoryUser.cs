using Microsoft.EntityFrameworkCore;
using Models;
using Models.Context;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Repositories
{
    public class RepositoryUser : IRepositoryUser
    {
        private readonly EntityContext _context;

        public RepositoryUser(EntityContext context)
        {
            _context = context;
        }

        public async Task<IUser> GetUserByUsername(string username)
        {
            var user = await _context.Users.Where(x => x.Username == username).SingleOrDefaultAsync();

            return user;
        }

        public async Task<IUser> Login(IUser model)
        {
            var user = await _context.Users
                                    .Where(x => x.Username == model.Username && x.Password==model.Password)
                                    .SingleOrDefaultAsync();
    
            return user;
        }

        public async Task<int> Registration(IUser model)
        {
            var user = new User(model);

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.UserID;
        }
    }
}
