using BussinesLayer.Concrete;
using DataAccessLayer.Concrete;
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
        Context c = new Context();
        int id;
        public ActionResult WriterProfile()
        {
            return View();
        }
        public ActionResult MyHeading(string p)
        {
           
            p = (string)Session["WriterMail"];
             var writeridinfo = c.Writers.Where(x=>x.WriterMail == p).
                Select(y=>y.WriterID).FirstOrDefault();
            ViewBag.d = writeridinfo;
            id = writeridinfo;
            var values = hm.GetListByWriter(writeridinfo);
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
            string writermailinfo = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == writermailinfo).
                Select(y => y.WriterID).FirstOrDefault();
            ViewBag.d = writeridinfo;
            p.HeadingDate = DateTime.Now;
            p.HeadingStatus = true;
            p.WriterID = writeridinfo;
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