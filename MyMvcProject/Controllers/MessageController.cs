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
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager cm = new MessageManager(new EfMessageDL());
        MessageValidator MessageRulesFromDistrict = new MessageValidator();
        public ActionResult Inbox()
        {
            var msgList = cm.GetListInbox();
            return View(msgList);
        }
        public ActionResult Sendbox()
        {
            var msgList = cm.GetListSendbox();
            return View(msgList);
        }
        public ActionResult GetInboxMessage(int id)
        {
            var values = cm.GetMessageById(id);
            return View(values);
        }
        public ActionResult GetSendboxMessage(int id)
        {
            var values = cm.GetMessageById(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message msg)
        {
            //WritersValidator writerRules =new WritersValidator();//Isvalid'i EditWriter için de kullanacağımız için; bu işlemleri District'e kaydırıyoruz. writerRules tanımını yukarıya aldık
            ValidationResult validationResult = MessageRulesFromDistrict.Validate(msg);
            if (validationResult.IsValid)
            {
                msg.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                cm.AddMessage(msg);
                return RedirectToAction("Sendbox");
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
    }
}