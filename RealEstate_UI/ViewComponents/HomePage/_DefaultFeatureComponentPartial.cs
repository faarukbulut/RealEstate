﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.CategoryDtos;
using RealEstate_UI.Models;

namespace RealEstate_UI.ViewComponents.HomePage
{
	public class _DefaultFeatureComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultFeatureComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync(ApiSettings.BaseUrl + "Categories");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
				return View(values);
			}

			return View();
		}
	}
}
