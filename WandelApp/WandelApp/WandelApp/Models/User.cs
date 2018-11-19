using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WandelApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public User()
        {

        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        //public async Task<bool> checkUser()
        //{
        //    HttpClient client = new HttpClient();
        //    var jsonString = JsonConvert.SerializeObject(username);
        //    HttpResponseMessage response = await client.PostAsJsonAsync<string>("http://localhost:62690/api/Login", jsonString);
        //    // return either true or false
        //    return response.IsSuccessStatusCode;
        //}
    }
}

