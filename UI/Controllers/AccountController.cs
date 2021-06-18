using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace UI.Controllers
{
    public class AccountController : Controller
    {
        HPContext db = new HPContext();

        public ActionResult First()
        {
            return RedirectToAction("Anasayfa", "Home", new { area = "Ziyaretci" });
        }
        // GET: Account
        public ActionResult Logout()
        {
            Session["currentUser"] = null;
            return RedirectToAction("Anasayfa", "Home", new { area = "Ziyaretci" });
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM data)
        {
            if (ModelState.IsValid)
            {
                User currentUser = db.Users.Where(x => x.UserName == data.UserName && x.Password == data.Password).FirstOrDefault();
                if (currentUser != null)
                {
                    //string cookie = currentUser.Email;

                    if (currentUser.Role == Role.Admin)
                    {
                        Session["currentUser"] = currentUser;
                        return RedirectToAction("Anasayfa", "Home", new { area = "Admin" });
                    }
                    else if (currentUser.Role == Role.Uzman)
                    {
                        Session["currentUser"] = currentUser;
                        return RedirectToAction("Anasayfa", "Home", new { area = "Ziyaretci" });
                    }
                    else if (currentUser.Role == Role.Ziyaretçi)
                    {
                        Session["currentUser"] = currentUser;
                        return RedirectToAction("Anasayfa", "Home", new { area = "Ziyaretci" });
                    }
                    else
                    {
                        return RedirectToAction("Anasayfa", "Home", new { area = "Ziyaretci" });

                    }
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User newUser)
        {
            newUser.Role = Role.Ziyaretçi;
            db.Users.Add(newUser);
            db.SaveChanges();
            return RedirectToAction("Register", "Account");
        }
        [HttpGet]
        public ActionResult RegisterUzman()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUzman(User newUser)
        {
            newUser.Role = Role.Uzman;
            db.Users.Add(newUser);
            db.SaveChanges();
            return RedirectToAction("Login", "Account");
        }
    }
}