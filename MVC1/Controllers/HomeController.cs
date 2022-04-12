using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
            Employee employee = employeeBL.GetEmployeeDetails(102);
            ViewData["Employee"] = employee;
            ViewData["Header"] = "Employee Details";


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}