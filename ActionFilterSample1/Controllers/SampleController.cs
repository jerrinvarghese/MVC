using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterSample1.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        [TestActionFilter]
        public ActionResult Index()
        {
            ViewBag.countries = "aabbcc";
            return View();
        }
    }
}