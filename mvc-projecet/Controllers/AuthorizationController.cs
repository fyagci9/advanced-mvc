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
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManager amc = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues = amc.GetList();
            return View(adminvalues);
        }

        [HttpGet]
        public ActionResult AddAdmin() 
        {
        return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            amc.AdminAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminvalue = amc.GetByID(id);
            return View(adminvalue);

        }
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            amc.adminUpdate(p);
            return RedirectToAction("Index");

        }
    }
}