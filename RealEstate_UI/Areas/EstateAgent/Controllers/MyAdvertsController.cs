using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.ProductDtos;

namespace RealEstate_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    [Authorize]
    public class MyAdvertsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MyAdvertsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int id)
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "estateagenttoken")?.Value;
            
            if(token != null)
            {
                id = 1;
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:44367/api/Products/ProductAdvertsListByEmployee?id=" + id);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultProductAdvertListWithCategoryByEmployeeDto>>(jsonData);
                    return View(values);
                }
            }

            return View();
        }
    }
}
