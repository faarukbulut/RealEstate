using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.SubFeatureRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubFeaturesController : ControllerBase
    {
        private readonly ISubFeatureRepository _subFeatureRepository;

        public SubFeaturesController(ISubFeatureRepository subFeatureRepository)
        {
            _subFeatureRepository = subFeatureRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSubFeatureList()
        {
            var values = await _subFeatureRepository.GetAllSubFeatureAsync();
            return Ok(values);
        }
    }
}
