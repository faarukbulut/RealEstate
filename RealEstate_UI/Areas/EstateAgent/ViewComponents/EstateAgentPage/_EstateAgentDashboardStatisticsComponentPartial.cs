using Microsoft.AspNetCore.Mvc;
using RealEstate_UI.Services;

namespace RealEstate_UI.Areas.EstateAgent.ViewComponents.EstateAgentPage
{
    public class _EstateAgentDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;

        public _EstateAgentDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory, ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userID = _loginService.GetUserId;

            #region Statistic1 - Toplam Ilan Sayısı
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:7287/api/Statistics/ProductCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.statistic1 = jsonData1;
            #endregion

            #region Statistic2 - Emlakçının Toplam İlan Sayısı
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync($"https://localhost:7287/api/Statistics/ProductCountByEmployeeId/{userID}");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.statistic2 = jsonData2;
            #endregion

            #region Statistic3 - Emlakçının Aktif İlan Sayısı
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync($"https://localhost:7287/api/Statistics/ProductCountByStatusTrue/{userID}");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.statistic3 = jsonData3;
            #endregion

            #region Statistic4 - Emlakçının Pasif İlan Sayısı
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync($"https://localhost:7287/api/Statistics/ProductCountByStatusFalse/{userID}");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.statistic4 = jsonData4;
            #endregion

            return View();
        }
    }
}
