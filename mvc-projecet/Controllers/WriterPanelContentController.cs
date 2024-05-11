using BussinesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
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
        public ActionResult MyHeading(string p)
        {
            Context c = new Context();
            
            p = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x=> x.WriterMail==p).
                Select(y=>y.WriterID).FirstOrDefault();

            var contentvalues = cm.GetListWriterId(writeridinfo);

            return View(contentvalues);
        }
    }
}