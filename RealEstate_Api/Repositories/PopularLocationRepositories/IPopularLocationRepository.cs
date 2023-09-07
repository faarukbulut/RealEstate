using RealEstate_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
    }
}
