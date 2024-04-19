using BussinesLayer.Abstract;
using BussinesLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_project.Controllers
{
    public class istatistikController : Controller
    {
        // GET: istatistik
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var CatCount = cm.GetList().Count;
            ViewBag.CatCount = CatCount;
            var a=cm.GetList();
            return View();
        }
    }
}