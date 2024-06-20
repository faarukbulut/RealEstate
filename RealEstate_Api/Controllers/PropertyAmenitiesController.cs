﻿using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.PropertyAmenityRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAmenitiesController : ControllerBase
    {
        private readonly IPropertyAmenityRepository _propertyAmenityRepository;

        public PropertyAmenitiesController(IPropertyAmenityRepository propertyAmenityRepository)
        {
            _propertyAmenityRepository = propertyAmenityRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ResultPropertyAmenityByStatusTrue(int id)
        {
            var values = await _propertyAmenityRepository.ResultPropertyAmenityByStatusTrueAsync(id);
            return Ok(values);
        }
    }
}
