using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.ProductDetailRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailRepository _productDetailRepository;

        public ProductDetailsController(IProductDetailRepository productDetailRepository)
        {
            _productDetailRepository = productDetailRepository;
        }

        [HttpGet("GetProductDetailByProductId/{id}")]
        public async Task<IActionResult> GetProductDetailByProductId(int id)
        {
            var values = await _productDetailRepository.GetProductDetailByProductIdAsync(id);
            return Ok(values);
        }
    }
}
