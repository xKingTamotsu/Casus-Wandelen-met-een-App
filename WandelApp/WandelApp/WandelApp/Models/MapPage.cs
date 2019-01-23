using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace WandelApp.Models
{
    public class MapPage :ContentPage {
        public MapPage(){
            var customMap = new CustomMap(){
                MapType = MapType.Street,
            };


            var pin = new CustomPin(){
                Type = PinType.Place,
                Position = new Position(37.79752, -122.40183),
                Label = "Xamarin SF Office",
                Address = "Somewere in the world 666",
                id = "xamrin test",
                url = "http://www.google.nl"
            };

            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));
        }
    }
}
