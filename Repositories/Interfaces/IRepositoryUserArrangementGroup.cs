using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Repositories.Interfaces
{
    public interface IRepositoryUserArrangementGroup
    {
        Task<IUserArrangementGroup> GetByArrangementGroupID(int id, int idArrGroup);
        Task<bool> Delete(int id, int arrGroupId);
        Task<bool> Save(IUserArrangementGroup userArrGroup);
    }
}
