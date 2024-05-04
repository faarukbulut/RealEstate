﻿using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.ProductDtos;
using RealEstate_Api.Repositories.ProductRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }

        [HttpGet("ProductDealOfTheDayStatusChangeOfToTrue/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeOfToTrue(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeOfToTrue(id);
            return Ok("İlan durumu aktif olarak güncellendi");
        }

		[HttpGet("ProductDealOfTheDayStatusChangeOfToFalse/{id}")]
		public async Task<IActionResult> ProductDealOfTheDayStatusChangeOfToFalse(int id)
		{
			_productRepository.ProductDealOfTheDayStatusChangeOfToFalse(id);
			return Ok("İlan durumu pasif olarak güncellendi");
		}

        [HttpGet("Last5ProductList")]
        public async Task<IActionResult> Last5ProductList()
        {
            var values = await _productRepository.GetLast5ProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductAdvertsListByEmployeeAndTrue")]
        public async Task<IActionResult> ProductAdvertsListByEmployeeAndTrue(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAndTrue(id);
            return Ok(values);
        }

        [HttpGet("ProductAdvertsListByEmployeeAndFalse")]
        public async Task<IActionResult> ProductAdvertsListByEmployeeAndFalse(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAndFalse(id);
            return Ok(values);
        }

        [HttpGet("Last5ProductByEmployeeList/{id}")]
        public async Task<IActionResult> Last5ProductByEmployeeList(int id)
        {
            var values = await _productRepository.GetLast5ProductByEmployeeAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productRepository.CreateProductAsync(createProductDto);
            return Ok("Ekleme başarılı");
        }


    }
}
