using RealEstate_Api.Dtos.ServiceDtos;

namespace RealEstate_Api.Repositories.ServiceRepositories
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        Task CreateServiceAsync(CreateServiceDto serviceDto);
        Task DeleteServiceAsync(int id);
        Task UpdateServiceAsync(UpdateServiceDto serviceDto);
        Task<GetByIDServiceDto> GetServiceAsync(int id);
    }
}
