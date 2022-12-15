using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RailwayReservationSystem.Models;
using RailwayReservationSystem.Models.DAL;

namespace RailwayReservationSystem.Controllers
{
    public class HomeController : Controller
    {

        private IRailwayRepository<Reservation> interfaceObj;
        public HomeController()
        {
            this.interfaceObj = new RailwayRepository<Reservation>();

        }

        public ActionResult Index()
        {
            var data = interfaceObj.GetModel();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Reservation res)

        {

            var data = interfaceObj.GetModel();
            if (data.Count() >= 7)
            {
                TempData["msg"] = "<script>alert('YOU CANNOT ADD MORE THAN 6 PASSENGER');</script>";
            }
            else
            {

                interfaceObj.InsertModel(res);
                interfaceObj.Save();

                return RedirectToAction("Index");
            }
            return View(res);

        }

        public ActionResult Delete(int id)
        {
            Reservation rt = interfaceObj.GetModelByID(id);
            return View(rt);
        }
        [HttpPost]
        public ActionResult Delete(int id, Reservation reservation)
        {

            interfaceObj.DeleteModel(id);
            interfaceObj.Save();
            return RedirectToAction("Index");
        }


    }
}