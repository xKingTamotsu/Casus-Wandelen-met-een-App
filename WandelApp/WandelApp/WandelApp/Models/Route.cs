using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
        [JsonIgnore]public List<POI> POIList { get; set; }

        [JsonIgnore] private HttpClient httpClient;

        public Route() {
                httpClient = new HttpClient();
        }
        public async Task MakeRoute(Route route){
            string jsonString = JsonConvert.SerializeObject(route);

            HttpResponseMessage response = await httpClient.PostAsJsonAsync("http://localhost:62690/api/route/", jsonString);

        }
    }
}
