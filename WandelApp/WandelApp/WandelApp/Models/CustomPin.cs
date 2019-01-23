using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace WandelApp.Models
{
    public class CustomPin : Pin {
        public string id{ get; set; }
        public string url{ get; set; }
    }
}
