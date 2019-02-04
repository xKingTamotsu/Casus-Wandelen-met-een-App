using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    public class Route{
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double length { get; set; }
        public string difficulty { get; set; }
        public bool wheelchairAccessible { get; set; }
        public bool approved { get; set; }
        public string createdBy { get; set; } //This will stay string or becomes a user object.
        public DateTime createdAt { get; set; }
        public List<POI> POIList { get; set; }
        public int routeRating { get; set; }
        public double distanceFromUser { get; set; }

        [JsonIgnore] wandelappEntities wandelappEntities;
        [JsonIgnore] private List<Route> allRoutes;

        public Route(){
            wandelappEntities = new wandelappEntities();
            allRoutes = new List<Route>();
        }

        public List<Route> getAllRoutes(){
            List<TRoute> routeDB = wandelappEntities.TRoute.ToList();
            List<Route> allRoutes = new List<Route>();
            foreach (var dbRoute in routeDB) {
                Route route = new Route() {
                    id = dbRoute.id,
                    name = dbRoute.name,
                    description = dbRoute.name,
                    length = dbRoute.length,
                    difficulty = dbRoute.difficulty,
                    wheelchairAccessible = dbRoute.wheelchairAccessible,
                    approved = dbRoute.approved,
                    createdBy = dbRoute.createdBy,
                    createdAt = dbRoute.createdAt
                };
                allRoutes.Add(route);
            }

            return allRoutes;
        }

        public void AddRoute(Route route) {
            TRoute tRoute = new TRoute() {
                name = route.name,
                description = route.description,
                length = route.length,
                difficulty = route.difficulty,
                wheelchairAccessible = route.wheelchairAccessible,
                approved = route.approved,
                createdBy = route.createdBy,
                createdAt = route.createdAt
            };

            wandelappEntities.TRoute.Add(tRoute);
            wandelappEntities.SaveChanges();
        }
    }
}