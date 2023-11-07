﻿using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.BottomGridDtos;
using RealEstate_Api.Repositories.BottomGridRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }

        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var value = await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(value);
        }

		[HttpPost]
		public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
		{
			_bottomGridRepository.CreateBottomGrid(createBottomGridDto);
			return Ok("Veri başarılı bir şekilde eklendi");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteBottomGrid(int id)
		{
			_bottomGridRepository.DeleteBottomGrid(id);
			return Ok("Veri başarılı bir şekilde silindi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
		{
			_bottomGridRepository.UpdateBottomGrid(updateBottomGridDto);
			return Ok("Veri başarılı bir şekilde düzenlendi");
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetBottomGrid(int id)
		{
			var value = await _bottomGridRepository.GetBottomGrid(id);
			return Ok(value);
		}

	}
}
