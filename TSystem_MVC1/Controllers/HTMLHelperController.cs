using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSystem_MVC1.Controllers
{
    public class HTMLHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
