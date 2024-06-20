using RealEstate_Api.Dtos.Category;

namespace RealEstate_Api.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto categoryDto);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(UpdateCategoryDTO categoryDto);
        Task<GetByIDCategoryDto> GetCategoryAsync(int id);
    }
}
