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
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager cm = new MessageManager(new EfMessageDL());
        public ActionResult Inbox()
        {
            var msgList = cm.GetListInbox();
            return View(msgList);
        }
        public ActionResult Sendbox() {
            var msgList = cm.GetListSendbox();
            return View(msgList);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message msg)
        {

            return View();
        }
    }
}