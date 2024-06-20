using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.StatisticRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticRepository _statisticRepository;

        public StatisticsController(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        [HttpGet("ActiveCategoryCount")]
        public async Task<IActionResult> ActiveCategoryCount()
        {
            var value = await _statisticRepository.ActiveCategoryCountAsync();
            return Ok(value);
        }

        [HttpGet("ActiveEmployeeCount")]
        public async Task<IActionResult> ActiveEmployeeCount()
        {
            var value = await _statisticRepository.ActiveEmployeeCountAsync();
            return Ok(value);
        }

        [HttpGet("ApartmentCount")]
        public async Task<IActionResult> ApartmentCount()
        {
            var value = await _statisticRepository.ApartmentCountAsync();
            return Ok(value);
        }

        [HttpGet("AverageProductPriceByRent")]
        public async Task<IActionResult> AverageProductPriceByRent()
        {
            var value = await _statisticRepository.AverageProductPriceByRentAsync();
            return Ok(value);
        }

        [HttpGet("AverageProductPriceBySale")]
        public async Task<IActionResult> AverageProductPriceBySale()
        {
            var value = await _statisticRepository.AverageProductPriceBySaleAsync();
            return Ok(value);
        }

        [HttpGet("AverageRoomCount")]
        public async Task<IActionResult> AverageRoomCount()
        {
            var value = await _statisticRepository.AverageRoomCountAsync();
            return Ok(value);
        }

        [HttpGet("CategoryCount")]
        public async Task<IActionResult> CategoryCount()
        {
            var value = await _statisticRepository.CategoryCountAsync();
            return Ok(value);
        }

        [HttpGet("CategoryNameByMaxProductCount")]
        public async Task<IActionResult> CategoryNameByMaxProductCount()
        {
            var value = await _statisticRepository.CategoryNameByMaxProductCountAsync();
            return Ok(value);
        }

        [HttpGet("CityNameByMaxProductCount")]
        public async Task<IActionResult> CityNameByMaxProductCount()
        {
            var value = await _statisticRepository.CityNameByMaxProductCountAsync();
            return Ok(value);
        }

        [HttpGet("DifferentCityCount")]
        public async Task<IActionResult> DifferentCityCount()
        {
            var value = await _statisticRepository.DifferentCityCountAsync();
            return Ok(value);
        }

        [HttpGet("EmployeeNameByMaxProductCount")]
        public async Task<IActionResult> EmployeeNameByMaxProductCount()
        {
            var value = await _statisticRepository.EmployeeNameByMaxProductCountAsync();
            return Ok(value);
        }

        [HttpGet("LastProductPrice")]
        public async Task<IActionResult> LastProductPrice()
        {
            var value = await _statisticRepository.LastProductPriceAsync();
            return Ok(value);
        }

        [HttpGet("NewestBuildingYear")]
        public async Task<IActionResult> NewestBuildingYear()
        {
            var value = await _statisticRepository.NewestBuildingYearAsync();
            return Ok(value);
        }

        [HttpGet("OldestBuildingYear")]
        public async Task<IActionResult> OldestBuildingYear()
        {
            var value = await _statisticRepository.OldestBuildingYearAsync();
            return Ok(value);
        }

        [HttpGet("PassiveCategoryCount")]
        public async Task<IActionResult> PassiveCategoryCount()
        {
            var value = await _statisticRepository.PassiveCategoryCountAsync();
            return Ok(value);
        }

        [HttpGet("ProductCount")]
        public async Task<IActionResult> ProductCount()
        {
            var value = await _statisticRepository.ProductCountAsync();
            return Ok(value);
        }

        [HttpGet("ProductCountByEmployeeId/{id}")]
        public async Task<IActionResult> ProductCountByEmployeeId(int id)
        {
            var value = await _statisticRepository.ProductCountByEmployeeIdAsync(id);
            return Ok(value);
        }

        [HttpGet("ProductCountByStatusFalse/{id}")]
        public async Task<IActionResult> ProductCountByStatusFalse(int id)
        {
            var value = await _statisticRepository.ProductCountByStatusFalseAsync(id);
            return Ok(value);
        }

        [HttpGet("ProductCountByStatusTrue/{id}")]
        public async Task<IActionResult> ProductCountByStatusTrue(int id)
        {
            var value = await _statisticRepository.ProductCountByStatusTrueAsync(id);
            return Ok(value);
        }

    }
}
