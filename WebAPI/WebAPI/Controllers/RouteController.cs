using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
    }
}
