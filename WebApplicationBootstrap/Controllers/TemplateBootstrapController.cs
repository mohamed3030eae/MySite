using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationBootstrap.Controllers
{
    public class TemplateBootstrapController : Controller
    {
        // GET: TemplateBootstrap
   
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

    }
}