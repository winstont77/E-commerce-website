﻿using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet(Name = "Home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
