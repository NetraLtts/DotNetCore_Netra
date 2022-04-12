using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //public string Index(int id)
        //{
        //    return "Id=" +id;
        //}

        public string Index(int id,string name)
        {
            return "Id=" + id + "Name=" +name;
        }
    }
}