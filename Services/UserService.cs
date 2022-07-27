using Repositories.Interfaces;
using Services.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Utils.ErrorModels;
using Utils.Handlers;
using Utils.Interfaces;
using Utils.Models;
using Microsoft.AspNetCore.Http;

namespace Services
{
    public class UserService:IUserService
    {
        private readonly IRepositoryUser _userRepo;
        private readonly IRepositoryRole _roleRepo;
        private readonly IRepositoryUserRole _userRoleRepo;
        private readonly JwtTokenGenerator _tokenGenerator;
        private readonly HttpContext _httpContext;

        public UserService(IHttpContextAccessor contextAccessor,IRepositoryUser userRepo, JwtTokenGenerator tokenGenerator, IRepositoryUserRole userRoleRepo, IRepositoryRole roleRepo)
        {
            _tokenGenerator = tokenGenerator;
            _userRepo = userRepo;
            _userRoleRepo = userRoleRepo;
            _httpContext = contextAccessor.HttpContext;
            _roleRepo = roleRepo;
        }

        public async Task<List<IUser>> GetAll()
        {
            try
            {
                var result = await _userRepo.GetAll();

                return result;
            }
            catch (Exception ex)
            {
                throw new BadRequestError("Cannot find all users");
            }
        }

        public async Task<IUser> GetLoggedInUser()
        {
            try
            {
                var id=_httpContext.User.Claims.FirstOrDefault().Value;
                var user = await _userRepo.GetByID(Int32.Parse(id));
                return user;
            }
            catch(Exception ex)
            {
                throw new UnautorizedError("Cannot find user with this param");
            }

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

            var jwtToken = _tokenGenerator.Generate(user);

            var token = new TokenModel
            {
                JWTToken = jwtToken
            };

            return token;
        }

        public async Task<bool> Registration(IUser model)
        {
            var existingUser = await _userRepo.GetUserByUsername(model.Username);

            if (existingUser != null)
            {
                throw new UnautorizedError("Cannot find user");
            }

            if (existingUser != null)
            {
                return false;
            }

            var roleID = await _roleRepo.GetRoleIdByName("User");

            if (roleID == null)
            {
                throw new UnautorizedError("Cannot find role with this name");
            }

            var userID = await _userRepo.Registration(model);

            if (userID == null)
            {
                throw new UnautorizedError("Cannot register user with this id");
            }

            UserRole userRole = new UserRole(userID, roleID);

            try
            {
                await _userRoleRepo.AddUserRole(userRole);
            }
            catch(Exception ex)
            {
                throw new BadRequestError("Cannot save user role");
            }

            return true;
        }
    }
}
