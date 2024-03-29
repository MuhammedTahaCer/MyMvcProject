﻿using DataAccess.EntityFrameWorks;
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
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryManager cm = new CategoryManager(new EfCategoryDL()); //farklı bir bileşene veya sisteme geçtiğimde ; olabildiğince az kod düzenlemesine ihtiyaç duymuş olalım   
        public ActionResult Index()
        {
            var cellValues = cm.GetMyCategory();
            return View(cellValues);
        }
        [HttpGet]
        public ActionResult AddmyCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddmyCategory(Category c)
        {
            CategoryValidator cv=new CategoryValidator();
            ValidationResult myResults=cv.Validate(c);
            if (myResults.IsValid)
            {
                cm.CategoryAdd(c);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var i in myResults.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeletemyCategory(int id) //bir view olmayacak sadece index üzerinden çalışacak
        {
            var ctgVal=cm.GetById(id);
            cm.CategoryDelete(ctgVal);//managerde tanımladıktan sonra sil(CategoryDelete) diyorum
            return RedirectToAction("Index");
        }


        //Update işlemi için 2 adım var. Günc. bilginin güncelleme sayfasına taşınması ve Günc. yapılması
        [HttpGet]
        public ActionResult UpdmyCategory(int id)
        {
            var ctgValEdt=cm.GetById(id);
            return View(ctgValEdt);
        }

        [HttpPost]
        public ActionResult UpdmyCategory(Category param)
        {
            cm.CategoryUpdate(param);
            return RedirectToAction("Index");
        }

    }
}