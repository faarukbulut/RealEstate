using RealEstate_Api.Dtos.ProductDetailDtos;
using RealEstate_Api.Dtos.ProductDtos;

namespace RealEstate_Api.Repositories.ProductRepositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        Task ProductDealOfTheDayStatusChangeOfToTrueAsync(int id);
        Task ProductDealOfTheDayStatusChangeOfToFalseAsync(int id);
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAndTrueAsync(int id);
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAndFalseAsync(int id);
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductByEmployeeAsync(int id);
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task<GetProductByProductIdDto> GetProductByProductIdAsync(int id);
        Task<List<ResultProductWithSearchListDto>> ResultProductWithSearchListAsync(string searchKey, int propertyCategoryId, int city);
    }
}
