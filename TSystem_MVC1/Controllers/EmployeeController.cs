using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystem_MVC1.Models;


namespace TSystem_MVC1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmpolyeeList()
        {
            List<Employeee> emp = new List<Employeee>()
            {
                new Employeee{Id=101,Name="tushar",Salary=50000 },
                 new Employeee{Id=102,Name="Suraj",Salary=25000 },
                  new Employeee{Id=103,Name="Poonam",Salary=40000 },
            };
            ViewData["Employee"] = emp;
            ViewBag.Employee = emp;
            return View();
            
        }
    }
}
