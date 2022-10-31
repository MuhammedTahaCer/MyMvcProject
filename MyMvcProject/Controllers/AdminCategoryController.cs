using DataAccess.EntityFrameWorks;
using DistinctiveLayer.Concrate;
using DistinctiveLayer.RulesFluentValidation;
using EntityLayer.Concrete_Somut;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterfaceLayer.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryManager cm = new CategoryManager(new EfCategoryDL()); //farklı bir bileşene veya sisteme geçtiğimde ; olabildiğince az kod düzenlemesine ihtiyaç duymuş olalım   
        public ActionResult Index()
        {
            var cellValues = cm.GetMyCategory();
            return View(cellValues);
        }
        [HttpGet]
        public ActionResult AddmyCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddmyCategory(Category c)
        {
            CategoryValidator cv=new CategoryValidator();
            ValidationResult myResults=cv.Validate(c);
            if (myResults.IsValid)
            {
                cm.CategoryAdd(c);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var i in myResults.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }
            }
            return View();
        }
    }
}