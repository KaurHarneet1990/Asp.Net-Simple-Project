using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.netProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //MVC version
        //public string Index()
        //{
        //    return typeof(Controller).Assembly.GetName().Version.ToString();
        //}

            //Views in an mvc application
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "Nepal",
                "USA",
                "Australia",
                "Newzealand"
            };
            return View();
        }
        
    }
}