using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProject.Controllers
{
    public class RegisterController : Controller
    {
        public RegContext dbAccessClass = new RegContext();
        // GET: Register
        
        public ActionResult Index()
        {
            return View();
        }
        //save to database
        [HttpPost]
        public ActionResult inputToDb(Register reg)
        {
           
            dbAccessClass.register.Add(reg);
            dbAccessClass.SaveChanges();
            return View();
        }

        public ActionResult dekhaune(int id)
        {

             //Register obj = dbAccessClass.register.Where(x=>x.UserID==id).SelectMany();
           // List<Register> obj = dbAccessClass.register.SqlQuery("Select * from registers where UserID = @p0", id).ToList();
            Register obj1 = dbAccessClass.register.SingleOrDefault();

            return View(obj1);
        }
    }
}