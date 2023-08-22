using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.ViewComponents.DefaultLayout
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
