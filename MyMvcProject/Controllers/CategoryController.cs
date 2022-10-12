using DataAccess.EntityFrameWorks;
using DistinctiveLayer.Concrate;
using DistinctiveLayer.RulesFluentValidation;
using EntityLayer.Concrete_Somut;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterfaceLayer.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryManager myCategoryManager = new CategoryManager(new EfCategoryDL());//DistinctiveLayer sınıfı için bir nesne türettim //Parantez içine: Managerların DL leri karşılacak sınıf/interfaceleri barındıracak bir Yapı
        public ActionResult Index()
        {
            return View(); //Bu sayfada Listeleme işlemi göstermek isteniyor.
        }
        public ActionResult GetMyCategory()
        {
             var cellvalues = myCategoryManager.GetMyCategory();//Artık EFden getiriyor //DistinctiveLayer daki sınıfımı çağırmam gerekiyor^^
            return View(cellvalues);
        }


        [HttpGet]//Sayfa yüklendiğinde çalışacak olan attribute. Postun üzerinde aynı metod
        public ActionResult AddMyCategory()
        {
            return View();
        }
        [HttpPost]//Sayfada bir buton vs aracılığıyla birşey post edilindiğinde bu çalışacak
        public ActionResult AddMyCategory(Category p)
        {
            //  cm.CategoryAddBL(p);
            CategoryValidator myValidator = new CategoryValidator();
                ValidationResult validationResult = myValidator.Validate(p);
            if (validationResult.IsValid)
            {
                myCategoryManager.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

    }
}