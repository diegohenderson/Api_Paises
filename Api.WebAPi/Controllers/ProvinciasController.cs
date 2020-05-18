using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.WebAPi.Controllers
{
    public class ProvinciasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}