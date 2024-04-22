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
    public class IstatistikController : Controller
    {
        // GET: istatistik
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {

            //toplam kategori sayısı
            
            var CatCount = cm.GetList().Count;
            ViewBag.CatCount = CatCount;

            //yazılım başlığı kategorisi
            var softwareCategory = cm.GetList().FirstOrDefault(x=>x.CategoryName=="yazılım");
            var softwareHeadingCount = hm.GetList().Count(x => x.CategoryID == softwareCategory.CategoryID);
            ViewBag.SoftwareHeadingCount = softwareHeadingCount;

            //a  sayısı
            var aLetter = wm.GetList().Count(x=>x.WriterName.Contains("a"));
            ViewBag.aLetter = aLetter;

            //en fazla başlığa sahip kategori adı
            var headingList = hm.GetList()
                .GroupBy(x => x.CategoryID)
                .Select(x => new { CategoryId = x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Count)
                .FirstOrDefault();
            var mostHeadingCategory = cm.GetByID(headingList.CategoryId).CategoryName;
            ViewBag.mostHeadingCategory = mostHeadingCategory;

            //true-false farkı

            var trueValue = cm.GetList().Count(x => x.CategoryStatus == true);
            var falseValue = cm.GetList().Count(x => x.CategoryStatus == false);
            var distanceValues = trueValue - falseValue;
            ViewBag.distanceValues = distanceValues;



            return View();
        }
    }
}