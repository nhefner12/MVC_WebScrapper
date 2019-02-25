using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebScrapper.Models
{

    public class CNBCCategories
    {
        public int CategoryID { get; set; }
        public string CategoryType { get; set; }
        public string CategoryLink { get; set; }
        public string CategoryHeadLineTitle { get; set; }
        public string CategoryHeadLineLink { get; set; }

        public CNBCCategories()
        {
            CategoryID = 1;
            CategoryType = "Default";
            CategoryLink = "";
            CategoryHeadLineTitle = "Default";
            CategoryHeadLineLink = "";
        }

        public CNBCCategories(int ID, string Type, string Link, string HeadLineTitle, string HeadLineLink)
        {
            this.CategoryID = ID;
            this.CategoryType = Type;
            this.CategoryLink = Link;
            this.CategoryHeadLineTitle = HeadLineTitle;
            this.CategoryHeadLineLink = HeadLineLink;
        }
    }
}