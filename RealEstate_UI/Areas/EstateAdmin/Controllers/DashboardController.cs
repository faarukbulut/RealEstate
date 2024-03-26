using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.Areas.EstateAdmin.Controllers
{
    [Area("EstateAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
