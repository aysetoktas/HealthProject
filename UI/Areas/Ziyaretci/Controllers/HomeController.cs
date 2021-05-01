using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Ziyaretci.Controllers
{
    public class HomeController : Controller
    {
        // GET: Ziyaretci/Home
        public ActionResult Anasayfa()
        {
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
        public ActionResult Paketler()
        {
            return View();
        }
    }
}