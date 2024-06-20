﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Areas.EstateAgent.Model;
using RealEstate_UI.Models;

namespace RealEstate_UI.Areas.EstateAgent.ViewComponents.EstateAgentPage
{
    public class _EstateAgentDashboardChartComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _EstateAgentDashboardChartComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(ApiSettings.BaseUrl + "Charts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<DashboardChartModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
