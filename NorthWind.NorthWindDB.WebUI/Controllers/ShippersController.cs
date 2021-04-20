using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebUI.Controllers
{
    public class ShippersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
