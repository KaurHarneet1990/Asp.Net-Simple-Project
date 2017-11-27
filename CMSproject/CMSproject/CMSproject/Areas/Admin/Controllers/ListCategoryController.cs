using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSproject.Areas.Admin.Controllers
{
    public class ListCategoryController : BaseAdminController
    {
        
        // GET: Admin/ListUser
        public ActionResult Index(string SortOrder, string SortBy, string Page)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;
            var category = objBll.categoryBll.GetAll();

            switch (SortBy)
            {
                case "Category":
                    switch (SortOrder)
                    {
                        case "Asc":
                            category = category.OrderBy(x => x.CategoryName).ToList();
                            break;
                        case "Desc":
                            category = category.OrderByDescending(x => x.CategoryName).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                case "CategoryDesc":
                    switch (SortOrder)
                    {
                        case "Asc":
                            category = category.OrderBy(x => x.CategoryDesc).ToList();
                            break;
                        case "Desc":
                            category = category.OrderByDescending(x => x.CategoryDesc).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    category = category.OrderBy(x => x.CategoryName).ToList();
                    break;
            }
            ViewBag.TotalPages = Math.Ceiling(objBll.categoryBll.GetAll().Count() / 4.0);
            int page = int.Parse(Page == null ? "1" : Page);
            ViewBag.Page = page;
            category = category.Skip((page - 1) * 4).Take(4);
            return View(category);
        }
        public ActionResult Delete(int id)
        {
            try
            {
                objBll.categoryBll.Delete(id);
                TempData["Msg"] = "Deleted Sucessfully";
                return RedirectToAction("Index");
            }
            catch(Exception el)
            {
                TempData["Msg"] = "Delete Failed : " + el.Message;
                return RedirectToAction("Index");
            }
        }
    }
}