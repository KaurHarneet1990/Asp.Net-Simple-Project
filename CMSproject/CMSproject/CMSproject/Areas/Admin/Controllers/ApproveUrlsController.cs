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
    }
}