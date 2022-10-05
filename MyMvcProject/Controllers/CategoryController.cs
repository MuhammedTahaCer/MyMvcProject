using DistinctiveLayer.Concrate;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryManager cm=new CategoryManager();//DistinctiveLayer sınıfı için bir nesne türettim
        public ActionResult Index()
        {
            return View(); //Bu sayfada Listeleme işlemi göstermek isteniyor.
        }

        public ActionResult GetMyCategory()
        {
            var cellvalues = cm.CategoryGetBL(); //DistinctiveLayer daki sınıfımı çağırmam gerekiyor^^
            return View(cellvalues);
        }
        public ActionResult AddMyCategory(Category p)
        {
            cm.CategoryAddBL(p);
            return RedirectToAction("GetMyCategory");
        }
    }
}