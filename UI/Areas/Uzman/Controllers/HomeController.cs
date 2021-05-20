using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Uzman.Controllers
{
    public class HomeController : Controller
    {
        // GET: Uzman/Home
        public ActionResult Anasayfa()
        {
            return View();
        }
    }
}