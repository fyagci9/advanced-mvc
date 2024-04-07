using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_projecet.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);

        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();

        }

        [HttpPost]
        public  ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p);

            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
           
            if (results.IsValid)
            {
                cm.CategoryAddBL(p);
                return RedirectToAction("GetCategoryList");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }

            return View();  
           
        }
    }
}