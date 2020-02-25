using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BWP.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AD(string name, int numTimes)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}