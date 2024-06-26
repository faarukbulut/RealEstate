﻿using Microsoft.AspNetCore.Mvc;
using RealEstate_UI.Models;
using System.Net.Http;

namespace RealEstate_UI.Areas.EstateAdmin.ViewComponents.AdminPage
{
    public class _AdminDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region Statistic1 - Toplam Ilan Sayısı
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync(ApiSettings.BaseUrl + "Statistics/ProductCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.statistic1 = jsonData1;
            #endregion

            #region Statistic2 - En Başarılı Personel
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync(ApiSettings.BaseUrl + "Statistics/EmployeeNameByMaxProductCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.statistic2 = jsonData2;
            #endregion

            #region Statistic3 - Ilandaki Şehir Sayıları
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync(ApiSettings.BaseUrl + "Statistics/DifferentCityCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.statistic3 = jsonData3;
            #endregion

            #region Statistic4 - Ortalama Kira Tutarı
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync(ApiSettings.BaseUrl + "Statistics/AverageProductPriceByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.statistic4 = jsonData4;
            #endregion

            return View();
        }
    }
}
