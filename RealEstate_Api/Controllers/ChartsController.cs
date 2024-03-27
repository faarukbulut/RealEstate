using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.ChartRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
        private readonly IChartRepository _chartRepository;

        public ChartsController(IChartRepository chartRepository)
        {
            _chartRepository = chartRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get5CityForChart()
        {
            var values = await _chartRepository.Get5CityForChart();
            return Ok(values);
        }
    }
}
