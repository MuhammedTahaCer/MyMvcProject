using DataAccess.EntityFrameWorks;
using DistinctiveLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterfaceLayer.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content

        ContentManager cm = new ContentManager(new EfContentDL()); //DataAccess Layer(DL) ile ilgili tablonyu işlemlere bağlıyorum (repository bağlantısı nerede..?) Neye, Distinct/Business Layerda oluşturduğum CRUD ve get işlemlerine. Buradaki kod ise managerdan bir nesne türetiyor sadece
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHead(int id) // filtreleyerek getirmek istiyorum.. Bunun için Business tarafı yapıyı kurmam lazım    ->    Content Manager ... Tamam artık paramatre verebilriim (int id)
        {
            var contentcell=cm.GetListByHeadId(id);
            return View(contentcell);
        }
    }
}