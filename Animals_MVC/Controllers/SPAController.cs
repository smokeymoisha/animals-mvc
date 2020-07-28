using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Animals_MVC.Controllers
{
    public class SPAController : Controller
    {
        // GET: SPA
        public ActionResult Index()
        {
            return View();
        }
    }
}