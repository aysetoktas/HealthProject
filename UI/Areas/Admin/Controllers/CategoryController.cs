using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        HPContext db = new HPContext();
        // GET: Admin/Category
        public ActionResult Listele(int? id)
        {
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Category data)
        {
            Category yeni = new Category();
            yeni.Name = data.Name;
            yeni.Description = data.Description;
            db.Categories.Add(yeni);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public ActionResult Güncelle(int? id)
        {
            Category guncelCategory = db.Categories.Find(id);
            return View(guncelCategory);
        }
        [HttpPost]
        public ActionResult Güncelle(Category data)
        {
            Category guncelCategory = db.Categories.Find(data.ID);
            guncelCategory.Name = data.Name;
            guncelCategory.Description = data.Description;
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
        public ActionResult Sil(int id)
        {
            Category silCategory = db.Categories.Find(id);
            db.Categories.Remove(silCategory);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
    }
}