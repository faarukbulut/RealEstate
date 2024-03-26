using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.Areas.EstateAdmin.ViewComponents.AdminLayout
{
    public class _AdminLayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
