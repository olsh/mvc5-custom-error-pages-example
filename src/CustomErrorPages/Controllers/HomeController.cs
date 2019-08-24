using System;
using System.Web.Mvc;

namespace CustomErrorPages.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            throw new Exception("Exception from MVC");
        }
    }
}
