﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebUI.Controllers
{
    public class RequestLogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
