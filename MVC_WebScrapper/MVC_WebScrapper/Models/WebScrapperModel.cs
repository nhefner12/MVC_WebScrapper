using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebScrapper.Models
{

    /// <summary>
    /// Info about the a site a web scrapper will be available for
    /// </summary>
    /// 
    public class WebScrapperModel
    {
        public WebScrapperModel()
        {
            ID = 0;
            Name = "Default";
            Description = "Default";
            Img = "Default";
        }

        public WebScrapperModel(int id, string name, string desc, string img)
        {
            ID = id;
            Name = name;
            Description = desc;
            Img = img;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
    }
}