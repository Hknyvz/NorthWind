using Microsoft.AspNetCore.Mvc;
using NorthWind.NorthWindDB.Entites.NorthWindEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            Type type = typeof(Categories);
            List<string> columnName = new List<string>();
            foreach (var item in type.GetProperties())
            {
                columnName.Add(item.Name);
            }
            return View(columnName);
        }
    }
}
