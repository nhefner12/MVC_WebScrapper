using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

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
            WebScrapperModel ws2 = new WebScrapperModel(2, "Fox News", "Data and stories coming from Fox News", "/Content/Images/New_Fox_News_Channel_logo.svg");

            result.Add(ws1);
            result.Add(ws2);

            return result;
        }
        public string GetUrlSource(string url)
        {
            url = url.Substring(0, 4) != "http" ? "http://" + url : url;
            string htmlCode = "";
            using (WebClient client = new WebClient())
            {
                try
                {
                    htmlCode = client.DownloadString(url);
                }
                catch (Exception ex)
                {
                    //TODO: Implement Custom Error
                }
            }
            return htmlCode;
        }
    }
}