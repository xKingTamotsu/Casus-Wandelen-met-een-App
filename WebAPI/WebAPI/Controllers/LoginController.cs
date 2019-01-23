using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using WebAPI.Models;

namespace WebAPI.Controllers {
    public class LoginController : ApiController {
        //TODO Add read,write,put and delete methods.

        [HttpPost]
        public IHttpActionResult Post([FromBody] string jsonString)
        {
            User userObject = JsonConvert.DeserializeObject<User>(jsonString);
            bool getSingleUser = userObject.CheckUser(userObject);

            if (getSingleUser) {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}