using AjaxDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult GetRandomNumber(int min, int max)
        {
            var rnd = new Random();
            var vm = new RandomNumberViewModel {Number = rnd.Next(min, max)};
            return Json(vm);
        }
    }
}
