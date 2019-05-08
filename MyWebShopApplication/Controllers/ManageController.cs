using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebShopApplication.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Manage()
        {
            return View();
        }
    }
}