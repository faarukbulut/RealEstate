using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.ViewComponents.DefaultLayout
{
    public class _DefaultNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
