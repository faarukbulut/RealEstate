using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.PopularLocationDtos;
using RealEstate_Api.Repositories.PopularLocationRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }

		[HttpPost]
		public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
		{
			await _popularLocationRepository.CreatePopularLocationAsync(createPopularLocationDto);
			return Ok("Popüler Lokasyon başarılı bir şekilde eklendi");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeletePopularLocation(int id)
		{
			await _popularLocationRepository.DeletePopularLocationAsync(id);
			return Ok("Popüler Lokasyon başarılı bir şekilde silindi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
		{
			await _popularLocationRepository.UpdatePopularLocationAsync(updatePopularLocationDto);
			return Ok("Popüler Lokasyon başarılı bir şekilde düzenlendi");
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetPopularLocation(int id)
		{
			var value = await _popularLocationRepository.GetPopularLocationAsync(id);
			return Ok(value);
		}
	}
}
