using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dentistas.Models;

namespace Dentistas.Controllers
{
    public class HomeController : Controller
    {
        private DentalCloudEntities1 db = new DentalCloudEntities1();
        public ActionResult Index()
        {
            return View(db.Odontologos.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Busqueda()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}