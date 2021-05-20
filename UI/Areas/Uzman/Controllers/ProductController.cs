using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Uzman.Controllers
{
    public class ProductController : Controller
    {
        HPContext db = new HPContext();
        // GET: Uzman/Product
        public ActionResult Listele(int? id)
        {
            List<Product> products = db.Products.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Product data)
        {
            Product yeni = new Product();
            yeni.Name = data.Name;
            yeni.Price = data.Price;
            yeni.Time = data.Time;
            yeni.Item1 = data.Item1;
            yeni.Item2 = data.Item2;
            yeni.Item3 = data.Item3;
            yeni.Item4 = data.Item4;
            yeni.Item5 = data.Item5;
            yeni.CategoryID = data.CategoryID;
            yeni.UserID = data.UserID;
            db.Products.Add(yeni);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public ActionResult Güncelle(int? id)
        {
            Product guncelProduct= db.Products.Find(id);
            return View(guncelProduct);
        }
        [HttpPost]
        public ActionResult Güncelle(Product data)
        {
            Product guncelProduct = db.Products.Find(data.ID);
            guncelProduct.Name = data.Name;
            guncelProduct.Price = data.Price;
            guncelProduct.Time = data.Time;
            guncelProduct.Item1 = data.Item1;
            guncelProduct.Item2 = data.Item2;
            guncelProduct.Item3 = data.Item3;
            guncelProduct.Item4 = data.Item4;
            guncelProduct.Item5 = data.Item5;
            guncelProduct.CategoryID = data.CategoryID;
            guncelProduct.UserID = data.UserID;
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
        public ActionResult Sil(int id)
        {
            Product silProduct = db.Products.Find(id);
            db.Products.Remove(silProduct);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
    }
}