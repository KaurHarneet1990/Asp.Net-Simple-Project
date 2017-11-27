using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSproject.Areas.Admin.Controllers
{
    public class BaseAdminController : Controller
    {
        protected AdminBll objBll;
        public BaseAdminController()
        {
            objBll = new AdminBll();
        }
    }
}