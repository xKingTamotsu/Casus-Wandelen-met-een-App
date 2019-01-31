using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WandelApp.Models
{
    public class Route{
        public int id{ get; set; }
        public string name{ get; set; }
        public string description{ get; set; }
        public double length{ get; set; }
        public string difficulty{ get; set; }
        public bool wheelchairAccessible{ get; set; }
        public bool approved{ get; set; }
        public User createdBy{ get; set; }
        public DateTime createdAt{ get; set; }
        public int routeRating{ get; set; }
        public double distanceFromUser{ get; set; }
        public List<POI> POIList { get; set; }
    }
}
