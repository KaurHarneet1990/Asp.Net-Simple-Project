using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;

namespace CMSproject.Areas.User.Controllers
{
    public class UrlController : Controller
    {
        private UrlBll objUrlBll;
        private CategoryBll objCatBll;
        private UserBll objUserBll;
        public UrlController()
        {
            objUrlBll = new UrlBll();
            objCatBll = new CategoryBll();
            objUserBll = new UserBll();
        }
        // GET: User/Url
        public ActionResult Index()
        {
            
            ViewBag.CategoryId = new SelectList(objCatBll.GetAll().ToList(), "CategoryId", "CategoryName");
            ViewBag.UserId = new SelectList(objUserBll.GetAll().ToList(), "UserId", "UserEmail");
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbl_Url myUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    objUrlBll.Insert(myUrl);
                    TempData["Msg"] = "Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Index");
                }
            }
            catch(Exception e1)
            {
                TempData["Msg"] = "Create Failed"+e1.Message;
                return RedirectToAction("Index");
            }
            
        }
    }
}