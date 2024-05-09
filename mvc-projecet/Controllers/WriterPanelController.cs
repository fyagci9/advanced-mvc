using BussinesLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_projecet.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public ActionResult WriterProfile()
        {
            return View();
        }
        public ActionResult MyHeading()
        {
           
            var values = hm.GetListByWriter();
            return View(values);
        }

        [HttpGet]
        public ActionResult NewHeading()
        {

            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),

                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            return View();
        }
        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            p.HeadingDate = DateTime.Now;
            p.HeadingStatus = true;
            p.WriterID = 4;
            hm.headingAdd(p);
            return RedirectToAction("MyHeading");
            
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),

                                                  }).ToList();

            ViewBag.vlc = valuecategory;

            var headingValues = hm.GetByID(id);
            return View(headingValues);

        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.headingUpdate(p);
            return RedirectToAction("MyHeading");
        }
        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue = hm.GetByID(id);
            HeadingValue.HeadingStatus = false;
            hm.headingDelete(HeadingValue);
            return RedirectToAction("MyHeading");


        }
    }
}