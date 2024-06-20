using RealEstate_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        Task CreatePopularLocationAsync(CreatePopularLocationDto popularLocationDto);
        Task DeletePopularLocationAsync(int id);
        Task UpdatePopularLocationAsync(UpdatePopularLocationDto popularLocationDto);
		Task<GetByIDPopularLocationDto> GetPopularLocationAsync(int id);
	}
}
