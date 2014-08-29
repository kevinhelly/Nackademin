using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace RestaurangGuide.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Fish = "";
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Fish = "Hej";
            return View("Index");
        }
    }
}
