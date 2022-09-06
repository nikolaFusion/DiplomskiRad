using Utils.Interfaces;

namespace Services.Interfaces
{
    public interface ITravelPlacesService
    {
        Task<List<ITravelPlace>> GetAllTravelPlace();
        Task<List<ITravelPlace>> FindByValue(string searchValue);
        Task<ITravelPlace> FindById(string id);
    }
}
