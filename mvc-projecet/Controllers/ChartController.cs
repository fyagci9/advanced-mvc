using EntityLayer.Concrete;
using mvc_projecet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_projecet.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);

        }
        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName = "yazılım",
                CategoryCount = 8
            }) ;

            ct.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                CategoryCount = 5
            });

            ct.Add(new CategoryClass()
            {
                CategoryName = "Dizi",
                CategoryCount = 3
            });

            ct.Add(new CategoryClass()
            {
                CategoryName = "film",
                CategoryCount = 7
            });

            ct.Add(new CategoryClass()
            {
                CategoryName = "Kitap",
                CategoryCount = 11
            });

            return ct;
        }
    }
}