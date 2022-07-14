using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Interfaces
{
    public interface IUserService
    {
        public Task<ITokenModel> Login(IUser user);
        public Task<bool> Registration(IUser user);
        Task<IUser> GetLoggedInUser();
        Task<List<IUser>> GetAll();
    }
}
