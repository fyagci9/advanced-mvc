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
    public class WriterPanelContentController : Controller
    {
        // GET: WriterPanelContent
        ContentManager cm = new ContentManager(new EfContentDal());
        Context c = new Context();
        public ActionResult MyHeading(string p)
        {
          
            
            p = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x=> x.WriterMail==p).
                Select(y=>y.WriterID).FirstOrDefault();

            var contentvalues = cm.GetListWriterId(writeridinfo);

            return View(contentvalues);
        }

        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).
                Select(y => y.WriterID).FirstOrDefault();

            p.ContentDate = DateTime.Parse (DateTime.Now.ToShortDateString());
            p.WriterID = writeridinfo;

            cm.contentAdd(p);
            p.ContentStatus = true;
            return RedirectToAction("MyHeading");
        }
        public ActionResult ToDoList() { 
        
        return  View();
        }
    }
}