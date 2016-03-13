using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eplandata.Controllers
{
    public class EplanController : Controller
    {
        // GET: Eplan
        public ActionResult Index()
        {
            return View();
        }

        public string Get()
        {
            return "hallo Welt";
        }
    }
}