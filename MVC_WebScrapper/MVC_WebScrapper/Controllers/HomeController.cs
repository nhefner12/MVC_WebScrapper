using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_WebScrapper.Models;
using MVC_WebScrapper.Models.Helpers;

namespace MVC_WebScrapper.Controllers
{
    public class HomeController : Controller
    {
        #region Globals

        WebScrappersHelper helper = new WebScrappersHelper();

        #endregion

        /// <summary>
        /// returns view of home page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// return view of about page
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            return View();
        }

        /// <summary>
        /// return view of all web scrappers provided
        /// </summary>
        /// <returns></returns>
        public ActionResult WebScrappers()
        {
            List<WebScrapperModel> listModel = helper.populateWebScrappers();

            return View(listModel);
        }
    }
}