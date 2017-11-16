using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSproject.Areas.Common.Controllers
{
    public class BrowseUrlController : Controller
    {
        private UrlBll objBll;
        public BrowseUrlController()
        {
            objBll = new UrlBll();
        }
        // GET: Common/BrowseUrl
        public ActionResult Index()
        {
            var url = objBll.GetAll();
            return View(url);
        }
    }
}