using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_MVC1.Models;


namespace TSystem_MVC1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
          List<Product> prolist = new List<Product>()
            {
                new Product{Id=1,Name="laptop",Price=50000 },
                 new Product{Id=2,Name="TV",Price=35000 },
                  new Product{Id=3,Name="machine",Price=20000 }
            };
            ViewData["Product"] = prolist;
            ViewBag.ProductList = prolist;
            return View();
        }
        public IActionResult AddnewItem()
        {
            return View();
        }
    }
}
