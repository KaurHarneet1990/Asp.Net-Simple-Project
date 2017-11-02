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
        public ActionResult Index()
        {
            EmployeeContext employeeContextKoObject = new EmployeeContext();
            List< Employee > employees = employeeContextKoObject.abcd.ToList();
            //Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);
            return View(employees);
        }
        //For Details
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContextKoObject = new EmployeeContext();
            Employee employee = new Employee();
            employee = employeeContextKoObject.abcd.SqlQuery("Select * from tblEmployee where EmployeeId = @p0", id).FirstOrDefault();
            //Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);
            return View(employee);
        }

        public ActionResult see()
        {
            Employee nayaemp = new Employee();
            nayaemp.EmployeeId = 15;
            nayaemp.Gender = "male";
            nayaemp.Name = "testname";
            nayaemp.City = "pkr";
            return View(nayaemp);
        }
    }
}