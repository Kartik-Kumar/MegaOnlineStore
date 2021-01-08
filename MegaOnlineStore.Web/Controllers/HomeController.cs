using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MegaOnlineStore.Web.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 70)]
        public ActionResult Index()
        {
            var date = DateTime.Now;
            ViewBag.Message = $"Your application description page.{date} ";
            return View();
        }
        [OutputCache(Duration = 70)]
        public ActionResult About()
        {
            var date = DateTime.Now;
            ViewBag.Message = $"Your application description page.{date} ";

            return View();
        }
        [OutputCache(Duration = 70)]
        public ActionResult Contact()
        {
            var date = DateTime.Now;
            ViewBag.Message = $"Your contact page.{date}";

            return View();
        }
    }
}