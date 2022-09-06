using Utils.Interfaces;

namespace Repositories.Interfaces
{
    public interface IRepositoryArranegementGroup
    {
        Task<IArrangementGroup> GetByID(int arrangementGroupID);
        Task<bool> DeleteArrGroup(int arrangementGroupID);
        Task<int> GetLastID();
        Task<bool> SaveArrGroup(IArrangementGroup arrGroup);
    }
}
