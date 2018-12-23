using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebScrapper.Models
{
    public class CNBCModel
    {
        
        public string Headline { get; set; }
        public string Img { get; set; }
        public string Detail { get; set; }

    }

    public class CNBCStories
    {
        public string Type { get; set; }
        public List<CNBCModel> stories { get; set; }
    }
}