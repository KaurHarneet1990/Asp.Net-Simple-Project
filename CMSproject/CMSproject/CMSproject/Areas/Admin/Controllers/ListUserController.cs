using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSproject.Areas.Admin.Controllers
{
    public class ListUserController : BaseAdminController
    {
        
        // GET: Admin/ListUser
        public ActionResult Index(string SortOrder, string SortBy, string Page)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;
            var users = objBll.userBll.GetAll();

            switch (SortBy)
            {
                case "UserEmail":
                    switch (SortOrder)
                    {
                        case "Asc":
                            users = users.OrderBy(x => x.UserEmail).ToList();
                            break;
                        case "Desc":
                            users = users.OrderByDescending(x => x.UserEmail).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                case "Role":
                    switch (SortOrder)
                    {
                        case "Asc":
                            users = users.OrderBy(x => x.Role).ToList();
                            break;
                        case "Desc":
                            users = users.OrderByDescending(x => x.Role).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    users = users.OrderBy(x => x.UserEmail).ToList();
                    break;
            }
            ViewBag.TotalPages = Math.Ceiling(objBll.userBll.GetAll().Where(x => x.Role == "U").Count() / 4.0);
            int page = int.Parse(Page == null ? "1" : Page);
            ViewBag.Page = page;
            users = users.Skip((page - 1) * 4).Take(4);
            return View(users);
        }
        public ActionResult Delete(int id)
        {
            try
            {
                objBll.userBll.Delete(id);
                TempData["Msg"] = "Deleted Sucessfully";
                return RedirectToAction("Index");
            }
            catch (Exception el)
            {
                TempData["Msg"] = "Delete Failed : " + el.Message;
                return RedirectToAction("Index");
            }
        }
    }
}