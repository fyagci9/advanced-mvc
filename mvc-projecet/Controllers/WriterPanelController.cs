using BussinesLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
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

        public ActionResult WriterProfile()
        {
            return View();
        }
        public ActionResult MyHeading()
        {
           
            var values = hm.GetListByWriter();
            return View(values);
        }
    }
}