using Railway_Reservation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Railway_Reservation.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext(); 
   
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult afterlogin()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Reservation r)
        {
            db.Reservations.Add(r);
            db.SaveChanges();
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
            return View();
        }
        public ActionResult Cancel()
        {
            return View();
        }
    }
}
