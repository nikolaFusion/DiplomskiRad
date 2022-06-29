using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Interfaces
{
    public interface ITravelPlacesService
    {
        Task<List<ITravelPlace>> GetAll();
    }
}
