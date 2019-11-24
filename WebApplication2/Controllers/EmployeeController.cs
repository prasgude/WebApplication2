using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee e = new Employee()
            {
                EmployeeId = 101,
                EmployeeName = "Suman",
                Gender = "Male",
                City = "Hyderabad"

            };

            return View(e);
        }
    }
}