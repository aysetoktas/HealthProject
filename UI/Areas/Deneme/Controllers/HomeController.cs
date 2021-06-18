using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Deneme.Controllers
{
    public class HomeController : Controller
    {
        // GET: Deneme/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkımızda()
        {
            return View();
        }
    }
}