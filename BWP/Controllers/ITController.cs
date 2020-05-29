using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BWP.Controllers
{
    public class ITController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int IT83(int id)
        {
            return id;
        }
    }
}