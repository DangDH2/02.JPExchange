using BUS.DAO;
using BUS.DTO;
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
        public ActionResult ViewListCategory()
        {
            String mess = "";
            try { 
                CategoryDTO DTO = new CategoryDTO();
                DTO.Name = "Thực phẩm";
                DTO.Index = 1;
                CategoryDAO dao = new CategoryDAO();
                mess = dao.AddCategory(DTO);
            }
            catch (Exception e)
            {
                mess = e.Message;
            }
            return PartialView("ListCategory", mess);
        }
    }
}
