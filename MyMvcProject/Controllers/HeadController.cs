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
        WriterManager wrm=new WriterManager(new EfWriterDL());
        public ActionResult Index()
        {
            var headcell=hm.GetHeads();
            return View(headcell);
        }
        public ActionResult AddHead()
        {
         //**Ekleme İşlemi Yapılırken DropdownList Oluşturuyoruz**

            List<SelectListItem> list = (from x in cm.GetMyCategory()
                                         select new SelectListItem
                                         {
                                             //Text ve Value adında iki deeğer alıcak. Value dediği hafızadaki değeri
                                             Text=x.CategoryName,
                                             Value=x.CategoryId.ToString()
                                         }).ToList();

            //Bu listeyi controller üzerinde viewbag ile view'e taşıyorum
            ViewBag.list = list;

         //**Ekleme İşlemi Yapılırken DropdownList Oluşturuyoruz**

         //** Yazarlar için ikinci bir dropdown oluşturuyoruz
            List<SelectListItem> list2 = (from y in wrm.GetList()
                                          select new SelectListItem
                                          {
                                              Text = y.WriterName + " " + y.Surname,
                                              Value = y.WriterId.ToString()
                                          }).ToList();
            ViewBag.list2 = list2;
         //** Yazarlar için ikinci bir dropdown oluşturuyoruz

            return View();
        }
        [HttpPost]
        public ActionResult AddHead(Head heads)
        {
            heads.HeadDate = DateTime.Parse(DateTime.Now.ToString());//parse etmeden toShort alamadı. Tarihi null girebildiğim için kapattım
            hm.HeadAdd(heads);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditHead(int id)
        {
            List<SelectListItem> list = (from x in cm.GetMyCategory()
                                         select new SelectListItem
                                         {
                                             Text = x.CategoryName,
                                             Value = x.CategoryId.ToString()
                                         }).ToList();
            ViewBag.list = list;
            var headcell=hm.GetById(id);
            return View(headcell);
        }
        [HttpPost]
        public ActionResult EditHead(Head head)
        {
            hm.HeadUpdate(head); return RedirectToAction("Index");
        }

        public ActionResult DeleteHead(int id)
        {
            var headcell = hm.GetById(id);
            headcell.Status = false;
            hm.HeadDelete(headcell);
            return RedirectToAction("index");
        }
    }
}