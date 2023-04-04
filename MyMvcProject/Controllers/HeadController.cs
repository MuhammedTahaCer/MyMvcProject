using DataAccess.EntityFrameWorks;
using DistinctiveLayer.Concrate;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterfaceLayer.Controllers
{
    public class HeadController : Controller
    {
        // GET: Head

        HeadMenager hm= new HeadMenager(new EfHeadDL());
        CategoryManager cm= new CategoryManager(new EfCategoryDL()); // Listede Kategorileri listelemek için CategoryDl dan nesne türetmem gerekicek
        public ActionResult Index()
        {
            var headingValues=hm.GetHeads();
            return View(headingValues);
        }
        public ActionResult AddHead()
        {
          //Ekleme İşlemi Yapılırken DropdownList Oluşturuyoruz
            List<SelectListItem> list = (from x in cm.GetMyCategory()
                                         select new SelectListItem
                                         {
                                             //Text ve Value adında iki deeğer alıcak. Value dediği hafızadaki değeri
                                             Text=x.CategoryName,
                                             Value=x.CategoryId.ToString()
                                         }).ToList();
            //Bu listeyi controller üzerinde viewbag ile view'e taşıyorum
            ViewBag.list = list; 
          //Ekleme İşlemi Yapılırken DropdownList Oluşturuyoruz
            return View();
        }
        [HttpPost]
        public ActionResult AddHead(Head heads)
        {
            //heads.HeadDate= DateTime.Parse(DateTime.Now.ToString());//parse etmeden toShort alamadı. Tarihi null girebildiğim için kapattım
            hm.HeadAdd(heads);
            return RedirectToAction("Index");
        }
    }
}