using RealEstate_Api.Dtos.ProductImageDtos;

namespace RealEstate_Api.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageListByProductIdAsync(int id);
    }
}
