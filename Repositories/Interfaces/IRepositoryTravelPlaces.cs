using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Repositories.Interfaces
{
    public interface IRepositoryTravelPlaces
    {
        Task<List<ITravelPlace>> GetAll();
        Task<List<ITravelPlace>> FindByValue(string? searchValue);
        Task<ITravelPlace> FindByID(int id);
    }
}
