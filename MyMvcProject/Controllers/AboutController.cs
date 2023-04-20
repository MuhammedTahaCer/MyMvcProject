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
    public class AboutController : Controller
    {
        // GET: About

        AboutManager aboutManager = new AboutManager(new EfAboutDL());
        public ActionResult Index()
        {
            var aboutcell = aboutManager.GetAboutMe();

            return View(aboutcell);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About a)
        {
            aboutManager.AddWriterInfo(a);
            return RedirectToAction("Index");
        }

        public PartialViewResult AddAboutPw()
        {
            return PartialView();
        }
    }
}