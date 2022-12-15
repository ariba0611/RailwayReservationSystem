using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RailwayReservationSystem.Models;

namespace RailwayReservationSystem.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Reservations.ToList();
            return View(data);
        }
    }
}