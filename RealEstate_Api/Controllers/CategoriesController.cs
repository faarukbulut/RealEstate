using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.Category;
using RealEstate_Api.Repositories.CategoryRepository;

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

        [HttpDelete]
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
    }
}
