using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.ProductImageRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageRepository _productImageRepository;

        public ProductImagesController(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageListByProductId(int id)
        {
            var value = await _productImageRepository.GetProductImageListByProductId(id);
            return Ok(value);
        }

    }
}
