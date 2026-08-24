using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Savemor.Models;

namespace Savemor.Controllers
{
    public class HomeController : Controller
    {
        private SavemorDBContext db = new SavemorDBContext();
        
        public ActionResult Index()
        {
            return View(db.Category.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Savemor Pharmacy";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacts";

            return View();
        }

        public ActionResult Cart()
        {
            ViewBag.Message = "Cart";

            return View();
        }

        public ActionResult Stores()
        {
            ViewBag.Message = "Stores";

            return View();
        }

        public ActionResult ReturnPolicy()
        {
            ViewBag.Message = "Return Policy";

            return View();
        }

        public ActionResult Disclaimers()
        {
            ViewBag.Message = "Disclaimers";

            return View();
        }

        public ActionResult PrivacyAndTerms()
        {
            ViewBag.Message = "Privacy And Terms";

            return View();
        }

        public ActionResult Catalogues()
        {
            ViewBag.Message = "Catalogues";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services";

            return View();
        }
    }
}
