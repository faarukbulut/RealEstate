using RealEstate_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
		void CreatePopularLocation(CreatePopularLocationDto popularLocationDto);
		void DeletePopularLocation(int id);
		void UpdatePopularLocation(UpdatePopularLocationDto popularLocationDto);
		Task<GetByIDPopularLocationDto> GetPopularLocation(int id);
	}
}
