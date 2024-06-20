using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.CategoryDtos;
using RealEstate_UI.Dtos.ProductDtos;
using RealEstate_UI.Models;
using RealEstate_UI.Services;
using System.Text;

namespace RealEstate_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    [Authorize]
    public class MyAdvertsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;

        public MyAdvertsController(IHttpClientFactory httpClientFactory, ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
        }

        public async Task<IActionResult> ActiveAdverts()
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "estateagenttoken")?.Value;
            
            if(token != null)
            {
                var userId = _loginService.GetUserId;
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync(ApiSettings.BaseUrl + "Products/ProductAdvertsListByEmployeeAndTrue?id=" + userId);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultProductAdvertListWithCategoryByEmployeeDto>>(jsonData);
                    return View(values);
                }
            }

            return View();
        }

        public async Task<IActionResult> PassiveAdverts()
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "estateagenttoken")?.Value;

            if (token != null)
            {
                var userId = _loginService.GetUserId;
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync(ApiSettings.BaseUrl + "Products/ProductAdvertsListByEmployeeAndFalse?id=" + userId);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultProductAdvertListWithCategoryByEmployeeDto>>(jsonData);
                    return View(values);
                }
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateAdvert()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(ApiSettings.BaseUrl + "Categories/");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

            List<SelectListItem> categoryValues = (from x in values.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.v = categoryValues;
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdvert(CreateProductDto createProductDto)
        {
            var id = _loginService.GetUserId;

            createProductDto.dealOfTheDay = false;
            createProductDto.advertisementDate = DateTime.Now;
            createProductDto.productStatus = true;
            createProductDto.employeeID = int.Parse(id);


            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createProductDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(ApiSettings.BaseUrl + "Products", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ActiveAdverts");
            }

            return View();
        }

    }
}
