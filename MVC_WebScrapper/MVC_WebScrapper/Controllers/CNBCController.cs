using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using MVC_WebScrapper.Models;
using MVC_WebScrapper.Models.Helpers;

namespace MVC_WebScrapper.Controllers
{
    public class CNBCController : Controller
    {
        CNBCHelper helper = new CNBCHelper();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Categories()
        {
            List<CNBCCategories> categories = helper.fetchCNBCStories();

            return View(categories);
        }

    }
}
