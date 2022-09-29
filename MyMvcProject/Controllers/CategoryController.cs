using DistinctiveLayer.Concrate;
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
            var TableCellValue = cm.CategoryGetBL(); //DistinctiveLayer daki sınıfımı çağırmam gerekiyor^^
            return View(TableCellValue);
        }
    }
}