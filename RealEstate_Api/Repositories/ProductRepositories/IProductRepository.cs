using RealEstate_Api.Dtos.ProductDtos;

namespace RealEstate_Api.Repositories.ProductRepositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        void ProductDealOfTheDayStatusChangeOfToTrue(int id);
        void ProductDealOfTheDayStatusChangeOfToFalse(int id);
    }
}
