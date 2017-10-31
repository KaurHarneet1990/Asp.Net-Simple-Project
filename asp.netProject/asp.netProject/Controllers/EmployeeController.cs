using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp.netProject.Models;

namespace asp.netProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Ram",
                Gender = "Male",
                City = "Pokhara"
            };
            return View(employee);
        }
    }
}