using DataAccess.EntityFrameWorks;
using DistinctiveLayer.Concrate;
using DistinctiveLayer.RulesFluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterfaceLayer.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        ContactManager cm= new ContactManager(new EfContactDL());
        ContactValidator cv=new ContactValidator();
        public ActionResult Index()
        {
            var contactValue = cm.GetList();
            return View(contactValue);
        }

        //Gelecek ders: Kullanıcıların kendi arasında mesajlaşacağı tablo ve Tarih kısmı db den gelicek (tıkladığında detaya gitmesi gerkiyor birde ama demedi)

        public ActionResult Details(int id) { 
            var contactValue = cm.GetContact(id);
            return View(contactValue);
        }

        public PartialViewResult Message()
        {
            return PartialView();
        }
    }
}