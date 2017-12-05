using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSproject.Areas.Admin.Controllers
{
    public class ApproveUrlsController : BaseAdminController
    {
        // GET: Admin/ApproveUrls
        public ActionResult Index(string Status)
        {
            ViewBag.Status = (Status == null ? "P" : Status);
            if (Status == null)
            {
                var urls = objBll.urlBll.GetAll().Where(x => x.IsApproved == "P").ToList();
                return View(urls);
            }
            else
            {
                var urls = objBll.urlBll.GetAll().Where(x => x.IsApproved == Status).ToList();
                return View(urls);
            }
        }
        
        public ActionResult Approve(int id)
        {
            try
            {
                //approve
                var myUrl = objBll.urlBll.GetByID(id);
                myUrl.IsApproved = "A";
                objBll.urlBll.Update(myUrl);
                TempData["Msg"] = "Approved Successfully";
                return RedirectToAction("Index");
            }
            catch(Exception e1)
            {
                TempData["Msg"] = "Approved Failed : " + e1.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult Reject(int id)
        {
            try
            {
                var myUrl = objBll.urlBll.GetByID(id);
                myUrl.IsApproved = "R";
                objBll.urlBll.Update(myUrl);
                TempData["Msg"] = "Reject Successfully";
                return RedirectToAction("Index");
            }
            catch (Exception e1)
            {
                TempData["Msg"] = "Rejection Failed : " + e1.Message;
                return RedirectToAction("Index");
            }
        }
    }
}