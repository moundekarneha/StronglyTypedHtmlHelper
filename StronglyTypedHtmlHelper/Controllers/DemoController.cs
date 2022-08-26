using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypedHtmlHelper.Models;

namespace StronglyTypedHtmlHelper.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Name = "Neha",
                Address = "Nagpur",
                isEmployee = true

            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
           return View();    
        }
    }
}