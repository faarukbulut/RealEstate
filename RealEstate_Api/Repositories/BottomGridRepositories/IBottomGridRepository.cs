using RealEstate_Api.Dtos.BottomGridDtos;

namespace RealEstate_Api.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        Task CreateBottomGridAsync(CreateBottomGridDto bottomGridDto);
        Task DeleteBottomGridAsync(int id);
        Task UpdateBottomGridAsync(UpdateBottomGridDto bottomGridDto);
        Task<GetBottomGridDto> GetBottomGridAsync(int id);
    }
}
