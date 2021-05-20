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
    }
}