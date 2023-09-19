using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.Category;
using RealEstate_Api.Repositories.CategoryRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoyRepository;

        public CategoriesController(ICategoryRepository categoyRepository)
        {
            _categoyRepository = categoyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoyRepository.GetAllCategoryAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoyRepository.CreateCategory(createCategoryDto);

            return Ok("Kategori başarılı bir şekilde eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoyRepository.DeleteCategory(id);
            return Ok("Kategori başarılı bir şekilde silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDTO updateCategoryDto)
        {
            _categoyRepository.UpdateCategory(updateCategoryDto);
            return Ok("Kategori başarılı bir şekilde düzenlendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _categoyRepository.GetCategory(id);
            return Ok(value);
        }

    }
}
