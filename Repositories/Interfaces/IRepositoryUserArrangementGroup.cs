using Utils.Interfaces;

namespace Repositories.Interfaces
{
    public interface IRepositoryUserArrangementGroup
    {
        Task<IUserArrangementGroup> GetByArrangementGroupID(int id, int idArrGroup);
        Task<bool> DeleteUserArr(int id, int arrGroupId);
        Task<bool> SaveUserArrGroup(IUserArrangementGroup userArrGroup);
        Task<List<IUserArrangementGroup>> GetByUserId(int id);
    }
}
