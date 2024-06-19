﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.ContactDtos;

namespace RealEstate_UI.Areas.EstateAdmin.ViewComponents.AdminPage
{
    public class _AdminDashboardLast4ContactComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardLast4ContactComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7287/api/Contacts/GetLast4ContactAsync");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last4ContactResultDto>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}
