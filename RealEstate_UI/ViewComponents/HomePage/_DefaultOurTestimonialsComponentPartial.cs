﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.TestimonialDtos;
using RealEstate_UI.Models;

namespace RealEstate_UI.ViewComponents.HomePage
{
    public class _DefaultOurTestimonialsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultOurTestimonialsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(ApiSettings.BaseUrl + "Testimonials");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
