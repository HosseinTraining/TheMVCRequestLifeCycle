using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheMVCRequestLifeCycle.Extention;
using TheMVCRequestLifeCycle.Filters;

namespace TheMVCRequestLifeCycle.Controllers
{
    [ActionFilter2]
    public class HomeController : Controller
    {

        [ActionFilter1]

       
        [AuthorizationFilter]
        public ActionResult Index()
        {
            return View();
        }

        [IsMobile]
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