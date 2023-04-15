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
    public class WriterController : Controller
    {
        // GET: Writer
        WritersValidator writerRulesFromDistrict = new WritersValidator();
        WriterManager wm = new WriterManager(new EfWriterDL());
        public ActionResult Index()
        {
            var writercell = wm.GetList();
            return View(writercell);
        }
        //Category Validator gibi burada veri akışı doğru sağlatmak için Validator oluşturmamız gerekiyor. Sonrasında Action ları belirtebilriz
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer writerparam)
        {
            //WritersValidator writerRules =new WritersValidator();//Isvalid'i EditWriter için de kullanacağımız için; bu işlemleri District'e kaydırıyoruz. writerRules tanımını yukarıya aldık
            ValidationResult validationResult = writerRulesFromDistrict.Validate(writerparam);
            if (validationResult.IsValid)
            {
                wm.WriterAdd(writerparam);
                return RedirectToAction("Index");
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
        [HttpGet]
        public ActionResult EditWriter(int id) 
        {
            var writer = wm.GetWriter(id);
            return View(writer);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer writerparam)
        {
            ValidationResult validationResult = writerRulesFromDistrict.Validate(writerparam);
            if (validationResult.IsValid)
            {
                wm.WriterUpdate(writerparam);//Değişen tek yer, (validation true ise) burası oldu
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(); //Aslında işlem burada tamamlandı. Butona ID tanımlamamız gerekiyor. Writer Index içerisinde=> Controller/Action/ID
        }

    }
}