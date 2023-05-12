using DataAccess.EntityFrameWorks;
using DistinctiveLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterfaceLayer.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager cm = new MessageManager(new EfMessageDL());
        public ActionResult Inbox()
        {
            var msgList = cm.GetList();
            return View(msgList);
        }
    }
}