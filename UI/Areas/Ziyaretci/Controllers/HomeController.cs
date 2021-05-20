﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Ziyaretci.Controllers
{
    public class HomeController : Controller
    {
        HPContext db = new HPContext();
        // GET: Ziyaretci/Home
        public ActionResult Anasayfa(int? id)
        {
            List<Category> categories = db.Categories.ToList();
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult UzmanKisiler()
        {
            return View();
        }
        public ActionResult Makaleler()
        {
            return View();
        }
        public ActionResult Makale()
        {
            return View();
        }

        public ActionResult Paketler(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("TümPaketler");
            }
            //Product product = db.Products.Find(id);
            List<Product> Bul(int id) => db.Products.Where(x => x.CategoryID == id).ToList();
            return View(Bul((int)id));

        }
        public ActionResult TümPaketler()
        {
            return View();

        }
    }
}