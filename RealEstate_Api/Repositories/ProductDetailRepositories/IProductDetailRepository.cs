using RealEstate_Api.Dtos.ProductDetailDtos;

namespace RealEstate_Api.Repositories.ProductDetailRepositories
{
    public interface IProductDetailRepository
    {
        Task<GetProductDetailByIdDto> GetProductDetailByProductIdAsync(int id);
    }
}
