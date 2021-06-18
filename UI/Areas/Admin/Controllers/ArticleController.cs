using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class ArticleController : Controller
    {
        HPContext db = new HPContext();
        // GET: Admin/Article
        public ActionResult Listele(int? id)
        {
            List<Article> articles = db.Articles.ToList();
            return View(articles);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Article data)
        {
            Article yeni = new Article();
            yeni.Title = data.Title;
            yeni.Description = data.Description;
            yeni.Yazar = data.Yazar;
            yeni.Tarih = data.Tarih;
            yeni.Etiket = data.Etiket;
            yeni.CategoryID = data.CategoryID;
            yeni.Kaynakca = data.Kaynakca;
           
            db.Articles.Add(yeni);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }

        [HttpGet]
        public ActionResult Güncelle(int? id)
        {
            Article guncelArticle = db.Articles.Find(id);
            return View(guncelArticle);
        }
        [HttpPost]
        public ActionResult Güncelle(Article data)
        {
            Article guncelArticle = db.Articles.Find(data.ID);
            guncelArticle.Title = data.Title;
            guncelArticle.Description = data.Description;
            guncelArticle.Yazar = data.Yazar;
            guncelArticle.Tarih = data.Tarih;
            guncelArticle.Etiket = data.Etiket;
            guncelArticle.CategoryID = data.CategoryID;
            guncelArticle.Kaynakca = data.Kaynakca;
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
        public ActionResult Sil(int id)
        {
            Article silArticle = db.Articles.Find(id);
            db.Articles.Remove(silArticle);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
    }
}