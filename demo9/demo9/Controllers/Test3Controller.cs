using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo9.Controllers
{
    public class Test3Controller : Controller
    {
        // GET: Test3
        public ActionResult Index()
        {
            ViewBag.message = "Hello world";
            return View();
        }
    }
}