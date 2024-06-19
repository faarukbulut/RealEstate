using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.ProductDetailDtos;
using RealEstate_UI.Dtos.ProductDtos;

namespace RealEstate_UI.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PropertyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7287/api/Products/ProductListWithCategory");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }

            return View();
        }

        public async Task<IActionResult> PropertyListWithSearch(string searchKey, int propertyCategoryId, string city)
        {
            searchKey = TempData["searchKey"].ToString();
            propertyCategoryId = int.Parse(TempData["tur"].ToString());
            city = TempData["city"].ToString();

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7287/api/Products/ResultProductWithSearchListAsync?searchKey={searchKey}&propertyCategoryId={propertyCategoryId}&city={city}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductWithSearchListDto>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PropertySingle(int id)
        {
            id = 1;
            ViewBag.ProductID = id;

            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7287/api/Products/GetProductByProductId/" + id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultProductDto>(jsonData);

            var responseMessage2 = await client.GetAsync("https://localhost:7287/api/ProductDetails/GetProductDetailByProductId/" + id);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<GetProductDetailByIdDto>(jsonData2);

            ViewBag.Title1 = values.title;
            ViewBag.Price = values.price;
            ViewBag.City = values.city;
            ViewBag.District = values.district;
            ViewBag.Address = values.address;
            ViewBag.Type = values.type;
            ViewBag.Description = values.description;
            ViewBag.Date = values.advertisementDate;

            DateTime date1 = DateTime.Now;
            DateTime date2 = values.advertisementDate;
            TimeSpan timeSpan = date1 - date2;
            ViewBag.DateDiff = timeSpan.Days;

            ViewBag.RoomCount = values2.roomCount;
            ViewBag.BathCount = values2.bathCount;
            ViewBag.BedCount = values2.bedRoomCount;
            ViewBag.ProductSize = values2.productSize;
            ViewBag.GarageSize = values2.garageSize;
            ViewBag.BuildYear = values2.buildYear;
            ViewBag.Location = values2.location;
            ViewBag.VideoUrl = values2.videoUrl;

            return View();

        }


    }
}
