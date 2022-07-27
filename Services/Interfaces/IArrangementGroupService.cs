using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Interfaces
{
    public interface IArrangementGroupService
    {
        Task<bool> Delete(string arrangementGroupID, string userID);
        Task<bool> Save(double Price, string userID, List<int> arrangementsIDs);
        Task<List<IArrangementGroup>> GetArrangemenyByUserId(string userID);
    }
}
