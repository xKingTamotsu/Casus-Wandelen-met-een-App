using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class RouteController : ApiController{

        [HttpGet]
        public IEnumerable<Route> Get(){
            Route route = new Route();
            List<Route> allRoutes = route.getAllRoutes();
            return allRoutes;
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] string jsonString) {

            Route routeObject = JsonConvert.DeserializeObject<Route>(jsonString);
            routeObject.AddRoute(routeObject);

            return Ok();
        }
    }
}
