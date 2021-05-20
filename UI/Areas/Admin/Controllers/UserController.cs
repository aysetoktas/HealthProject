using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        HPContext db = new HPContext();
        // GET: Admin/User
        public ActionResult ZiyaretciListele()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ZiyaretciGüncelle(int? id)
        {
            User guncelUser = db.Users.Find(id);
            return View(guncelUser);
        }
        [HttpPost]
        public ActionResult ZiyaretciGüncelle(User data)
        {
            User guncelUser = db.Users.Find(data.ID);
            guncelUser.FirstName = data.FirstName;
            guncelUser.LastName = data.LastName;
            guncelUser.Email = data.Email;
            guncelUser.Password = data.Password;
            guncelUser.PhoneNumber = data.PhoneNumber;
            db.SaveChanges();
            return RedirectToAction("ZiyaretciListele");
        }
        public ActionResult ZiyaretciSil(int id)
        {
            User silUser = db.Users.Find(id);
            db.Users.Remove(silUser);
            db.SaveChanges();
            return RedirectToAction("ZiyaretciListele");
        }


        public ActionResult UzmanListele()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UzmanGüncelle(int? id)
        {
            User guncelUser = db.Users.Find(id);
            return View(guncelUser);
        }
        [HttpPost]
        public ActionResult UzmanGüncelle(User data)
        {
            User guncelUser = db.Users.Find(data.ID);
            guncelUser.FirstName = data.FirstName;
            guncelUser.LastName = data.LastName;
            guncelUser.Email = data.Email;
            guncelUser.Password = data.Password;
            guncelUser.PhoneNumber = data.PhoneNumber;
            guncelUser.Facebook = data.Facebook;
            guncelUser.Instagram = data.Instagram;
            guncelUser.Linkedin = data.Linkedin;
            guncelUser.Picture = data.Picture;
            guncelUser.Title = data.Title;
            guncelUser.Description = data.Description;
            db.SaveChanges();
            return RedirectToAction("UzmanListele");
        }
        public ActionResult UzmanSil(int id)
        {
            User silUser = db.Users.Find(id);
            db.Users.Remove(silUser);
            db.SaveChanges();
            return RedirectToAction("UzmanListele");
        }
    }
}