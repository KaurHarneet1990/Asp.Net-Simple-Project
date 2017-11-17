﻿using BLL;
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
        public ActionResult Index(string SortOrder,string SortBy)
        {
            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;
            var url = objBll.GetAll().Where(x=>x.IsApproved=="A");
            switch(SortBy)
            {
                case"Title":
                    switch (SortOrder)
                    {
                        case "Asc":
                            url = url.OrderBy(x => x.UrlITitle).ToList();
                            break;
                        case "Desc":
                            url = url.OrderByDescending(x => x.UrlITitle).ToList();
                            break;
                    }
                    break;
                case "Category":
                    switch (SortOrder)
                    {
                        case "Asc":
                            url = url.OrderBy(x => x.tbl_Category.CategoryName).ToList();
                            break;
                        case "Desc":
                            url = url.OrderByDescending(x => x.tbl_Category.CategoryName).ToList();
                            break;
                    }
                    break;
                case "Url":
                    switch (SortOrder)
                    {
                        case "Asc":
                            url = url.OrderBy(x => x.Url).ToList();
                            break;
                        case "Desc":
                            url = url.OrderByDescending(x => x.Url).ToList();
                            break;
                    }
                    break;
                case "UrlDesc":
                    switch (SortOrder)
                    {
                        case "Asc":
                            url = url.OrderBy(x => x.UrlDesc).ToList();
                            break;
                        case "Desc":
                            url = url.OrderByDescending(x => x.UrlDesc).ToList();
                            break;
                    }
                    break;
                default:
                    url = url.OrderBy(x => x.UrlITitle).ToList();
                    break;


            }
            ViewBag.TotalPages = Math.Ceiling(objBll.GetAll().Where(x => x.IsApproved == "A").Count() / 10.0);
            
            return View(url);
        }
    }
}