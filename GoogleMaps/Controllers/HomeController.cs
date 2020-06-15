using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleMaps.Models;

namespace GoogleMaps.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            // создадим список данных
            List<Station> stations = new List<Station>();
            stations.Add(new Station()
            {
                Id = 1,
                PlaceName = "Библиотека имени Ленина",
                GeoLat = 37.610489,
                GeoLong = 55.752308,
                Line = "Сокольническая",
                Traffic = 1.0
            }) ;
            stations.Add(new Station()
            {
                Id = 2,
                PlaceName = "Александровский сад",
                GeoLat = 37.608644,
                GeoLong = 55.75226,
                Line = "Арбатско-Покровская",
                Traffic = 1.2
            });
            stations.Add(new Station()
            {
                Id = 3,
                PlaceName = "Боровицкая",
                GeoLat = 37.609073,
                GeoLong = 55.750509,
                Line = "Серпуховско-Тимирязевская",
                Traffic = 1.0
            });

            return Json(stations, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Route()
        {


            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}