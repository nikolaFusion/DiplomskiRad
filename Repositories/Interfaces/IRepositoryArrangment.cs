using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Repositories.Interfaces
{
    public interface IRepositoryArrangment
    {
        Task<List<IArrangement>> GetBeforeEndDate(int place, DateTime startDate, DateTime? endDate, int numberOfPeople,bool last);
    }
}
