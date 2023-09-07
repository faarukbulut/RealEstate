using RealEstate_Api.Dtos.Category;

namespace RealEstate_Api.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDTO categoryDto);
        Task<GetByIDCategoryDto> GetCategory(int id);
    }
}
