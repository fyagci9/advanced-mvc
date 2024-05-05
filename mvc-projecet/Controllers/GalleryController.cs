using BussinesLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_projecet.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery

        ImageFileManager imf = new ImageFileManager(new EfImageFileDal());

        public ActionResult Index()
        {
           var files = imf.GetList();
            return View(files);
        }
    }
}