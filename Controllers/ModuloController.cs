using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kiosko.Controllers
{
    public class ModuloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Crear()
        {
            return View();
        }
    }
}
