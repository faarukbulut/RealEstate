﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class MyAdvertsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
