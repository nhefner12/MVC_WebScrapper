using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVC_WebScrapper.Controllers
{
    public class CNBCController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
