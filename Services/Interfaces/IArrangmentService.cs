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
        Task<List<List<IArrangement>>> GetFindingArr(List<int> travelPlaceList, DateTime startDate, DateTime? endDate, int numberOfPeople);
    }
}
