using JPExchange_v01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JPExchange_v01.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowListCategories()
        {
            return PartialView("ListCategories");
        }
    }
}
