using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebScrapper.Models.Helpers
{
    /// <summary>
    /// Performs all of the logic needed to be done on the WebScrappersModel
    /// </summary>
    public class WebScrappersHelper
    {

        /// <summary>
        /// Returns a list of webscrappers currently implemeted 
        /// </summary>
        /// <returns></returns>
        public List<WebScrapperModel> populateWebScrappers()
        {
            List<WebScrapperModel> result = new List<WebScrapperModel>();

            //Fill Web Scrapper information
            WebScrapperModel ws1 = new WebScrapperModel(1, "CNBC", "Data and stories coming from CNBC", "/Content/Images/CNBC_logo.svg");

            result.Add(ws1);

            return result;
        }
    }
}