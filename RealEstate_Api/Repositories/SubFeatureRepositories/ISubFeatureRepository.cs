using RealEstate_Api.Dtos.SubFeatureDtos;

namespace RealEstate_Api.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();
    }
}
