using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.ViewComponents.DefaultLayout
{
    public class _DefaultScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
