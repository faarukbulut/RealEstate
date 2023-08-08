using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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


    }
}
