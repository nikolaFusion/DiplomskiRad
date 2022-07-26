using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Interfaces
{
    public interface IArrangmentService
    {
        Task<List<IArrangementGroup>> GetFindingArr(List<int> travelPlaceList, DateTime startDate, DateTime? endDate, int numberOfPeople);
        Task<List<IArrangement>> GetArrangementByFilter(string travelPlaceId, int numberOfPlace, DateTime startDate, DateTime endDate, double downPrice, double upPrice);
        Task<List<IArrangement>> FindAllByPlaceId(string id);
    }
}
