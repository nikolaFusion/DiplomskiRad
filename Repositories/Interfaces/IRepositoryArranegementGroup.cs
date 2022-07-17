using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Repositories.Interfaces
{
    public interface IRepositoryArranegementGroup
    {
        Task<IArrangementGroup> GetByID(int arrangementGroupID);
        Task<bool> Delete(int arrangementGroupID);
        Task<int> GetLastID();
        Task<bool> Save(IArrangementGroup arrGroup);
    }
}
