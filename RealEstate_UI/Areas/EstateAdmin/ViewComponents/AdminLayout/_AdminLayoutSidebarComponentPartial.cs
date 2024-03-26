using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.Areas.EstateAdmin.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
