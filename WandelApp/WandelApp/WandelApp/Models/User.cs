using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WandelApp.Models{
    public class User{
        [JsonProperty("username")] public string username{ get; set; }
        [JsonProperty("password")] public string password{ get; set; }
        [JsonIgnore] private HttpClient httpClient;

        public User(){
            httpClient = new HttpClient();
        }

        public User(string username, string password){
            this.username = username;
            this.password = password;
        }



        public async Task<bool> checkUser(User user){
            string jsonString = JsonConvert.SerializeObject(user);

            using (HttpResponseMessage response =
                await httpClient.PostAsJsonAsync("http://192.168.1.5:62690/api/login/", jsonString)){

                return response.IsSuccessStatusCode;
            }
        }
    }
}