using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxDemo.Models;

namespace AjaxDemo.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Person person)
        {
            var db = new PersonDb(@"Data Source=.\sqlexpress;Initial Catalog=OneToManyDemo;Integrated Security=true;");
            db.Add(person);
            return Json(person);
        }

        public IActionResult GetAll()
        {
            var db = new PersonDb(@"Data Source=.\sqlexpress;Initial Catalog=OneToManyDemo;Integrated Security=true;");
            List<Person> ppl = db.GetAll();
            return Json(ppl);
        }
    }
}
