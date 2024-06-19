using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.Controllers
{
    public class DefaultController : Controller
    {
		public IActionResult Index()
        {
			return View();
        }

        [HttpPost]
        public IActionResult PartialSearch(string searchKey, int tur, string city)
        {
            TempData["searchKey"] = searchKey;
            TempData["tur"] = tur;
            TempData["city"] = city;
			return RedirectToAction("PropertyListWithSearch", "Property");
        }
    }
}
