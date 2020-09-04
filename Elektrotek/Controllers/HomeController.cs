using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elektrotek.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sayfamizi anlatacak kisim";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "iletisim";

            return View();
        }
    }
}