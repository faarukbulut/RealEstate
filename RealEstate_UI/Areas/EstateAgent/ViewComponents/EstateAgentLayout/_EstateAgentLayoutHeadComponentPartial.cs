using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.Areas.EstateAgent.ViewComponents.EstateAgentLayout
{
    public class _EstateAgentLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
