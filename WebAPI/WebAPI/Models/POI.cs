using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class POI{
        public int id { get; set; }
        public int routeId { get; set; }
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public CategoryPOI categoryPOI { get; set; }
    }
}