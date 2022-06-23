using Models;
using Repositories.Interfaces;
using Services.Handlers;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services
{
    public class UserService:IUserService
    {
        private readonly IRepositoryUser _userRepo;
        private readonly IRepositoryRole _roleRepo;
        private readonly IRepositoryUserRole _userRoleRepo;
        private readonly JwtTokenGenerator _tokenGenerator=new JwtTokenGenerator();

        public UserService(IRepositoryUser userRepo, JwtTokenGenerator tokenGenerator, IRepositoryUserRole userRoleRepo, IRepositoryRole roleRepo)
        {
            _tokenGenerator = tokenGenerator;
            _userRepo = userRepo;
            _userRoleRepo = userRoleRepo;
            _roleRepo = roleRepo;
        }

        public async Task<ITokenModel> Login(IUser model)
        {
            var user = await _userRepo.Login(model);

            if (user == null)
            {
                return null;
            }

            var authClaims = new List<Claim>
            {
                new Claim("username", model.Username)
            };

            var token = _tokenGenerator.GetToken(authClaims);

            return token;
        }

        public async Task<bool> Registration(IUser model)
        {
            var existingUser = await _userRepo.GetUserByUsername(model.Username);

            if (existingUser != null)
            {
                return false;
            }

            var roleID = await _roleRepo.GetRoleIdByName("User");

            var userID = await _userRepo.Registration(model);

            var userRole = new UserRole
            {
                RoleID = roleID,
                UserID = userID
            };

            await _userRoleRepo.AddUserRole(userRole);  

            return true;
        }
    }
}
