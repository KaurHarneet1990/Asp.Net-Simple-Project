using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;

namespace CMSproject.Areas.User.Controllers
{
    public class UrlController : Controller
    {
        CMSdbContext db = new CMSdbContext();
        // GET: User/Url
        public ActionResult Index()
        {
            
            ViewBag.CategoryId = new SelectList(db.TableCategory, "CategoryId", "CategoryName");
            return View();
        }
        public ActionResult Create(tbl_Url objUrl)
        {
            db.TableUrl.Add(objUrl);
            db.SaveChanges();
            return View();
        }
    }
}