using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_WebScrapper.Models;
using HtmlAgilityPack;

namespace MVC_WebScrapper.Models.Helpers
{
    public sealed class CNBCHelper : WebScrappersHelper
    {
        private string baseURL = "https://www.cnbc.com/";


        public List<CNBCCategories> fetchCNBCStories()
        {
            string strHTML = GetUrlSource(baseURL);
            List<CNBCCategories> categories = new List<CNBCCategories>();

            if (!String.IsNullOrEmpty(strHTML))
            {
                try
                {
                    parseCNBCMainPage(categories, strHTML);
                }
                catch
                {
                    //TODO: Implement Custom Exception
                }

            }
            else
            {
                //TODO: Implement Custom Exception
            }

            return categories;
        }

        /// <summary>
        /// This function will parse the main page of CNBC "https://www.cnbc.com/"
        /// </summary>
        /// <param name="stories"></param>
        /// <param name="strHTML"></param>
        /// <returns>Int to determine if function was a success or not.
        /// 0 = success
        /// 1 = Error</returns>
        private int parseCNBCMainPage(List<CNBCCategories> categories, string strHTML)
        {
            int idCount = 1;
            try
            {
                HtmlDocument html = new HtmlDocument();
                html.LoadHtml(strHTML);
                HtmlNode root = html.DocumentNode;

                HtmlNode basepageSections = root.SelectSingleNode("//div[@id='root']//div//div[@id='BrandPageWrapper']//div[@id='MainContent']//div//div//div");  //inital page parse

                if (basepageSections == null)
                {
                    //TODO: Implement Custom Exception
                    return 1;
                }

                HtmlNode pageHeaderStories = basepageSections.ChildNodes[3]; // select 4th child node (as per analysis of source page)

                if (pageHeaderStories == null)
                {
                    //TODO: Implement Custom Exception
                    return 1;
                }

                HtmlNode firstCategory = pageHeaderStories.SelectSingleNode("//div//div[@id='HeroLedePlusThree-4']" +
                                                                    "//div[@class='HeroLedePlusThreeHero-container']" +
                                                                    "//div[@id='HeroLedePlusThreeLeadItem']");
                if (firstCategory == null)
                {
                    //TODO: Implement Custom Exception
                    return 1;
                }

                string categoryLink = firstCategory.SelectSingleNode("//div[@class='HeroLedePlusThreeLeadItem-eyebrowDiv']//a").Attributes["href"].Value;
                string categoryType = firstCategory.SelectSingleNode("//div[@class='HeroLedePlusThreeLeadItem-eyebrowDiv']//a").InnerHtml;

                string categoryHeadLine = firstCategory.SelectSingleNode("//h2//a").Attributes["title"].Value;
                string categoryHeadLineLink = firstCategory.SelectSingleNode("//h2//a").Attributes["href"].Value;

                if (categoryLink == null || categoryType == null || categoryHeadLine == null || categoryHeadLineLink == null)
                {
                    //TODO: Implement Custom Exception
                    return 1;
                }

                categories.Add(new CNBCCategories(idCount, categoryType, categoryLink, categoryHeadLine, categoryHeadLineLink));
            }
            catch
            {
                //TODO: Implement Custom Exception
                return 1;
            }

            return 0;
        }
    }

}