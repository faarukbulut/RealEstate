using RealEstate_Api.Dtos.AppUserDtos;

namespace RealEstate_Api.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductIdAsync(int id);
    }
}
