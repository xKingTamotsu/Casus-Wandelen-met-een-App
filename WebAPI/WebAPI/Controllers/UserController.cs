using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers {
    public class UserController : ApiController {
        private User user;

        public UserController() {
            user = new User();
        }


        //[HttpGet]
        //public IEnumerable<Models.User> GetUsers() {
        //    var resultaat = user.GetAllUsers();
        //    return resultaat;
        //}
    }
}