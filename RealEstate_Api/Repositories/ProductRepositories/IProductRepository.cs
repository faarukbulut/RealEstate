using RealEstate_Api.Dtos.ProductDetailDtos;
using RealEstate_Api.Dtos.ProductDtos;

namespace RealEstate_Api.Repositories.ProductRepositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        void ProductDealOfTheDayStatusChangeOfToTrue(int id);
        void ProductDealOfTheDayStatusChangeOfToFalse(int id);
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAndTrue(int id);
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAndFalse(int id);
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductByEmployeeAsync(int id);
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task<GetProductByProductIdDto> GetProductByProductIdDto(int id);
    }
}
