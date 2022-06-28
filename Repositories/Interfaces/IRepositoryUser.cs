using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Repositories.Interfaces
{
    public interface IRepositoryUser
    {
        Task<IUser> Login(IUser user);
        Task<IUser> GetUserByUsername(string username);
        Task<int> Registration(IUser model);
        Task<IUser> GetByID(int id);
        Task<List<IUser>> GetAll();
    }
}
