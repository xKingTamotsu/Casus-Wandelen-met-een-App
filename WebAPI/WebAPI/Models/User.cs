using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    public class User {
        public string username { get; set; }
        public string password { get; set; }
        public int roleId { get; set; }
        public DateTime createdAt { get; set; }
        public bool resetted { get; set; }
        public bool firstLogin { get; set; }

        

        [JsonIgnore] wandelappEntities wandelappEntities;
        [JsonIgnore] private List<User> allUsers;
        [JsonIgnore] private bool userCheck;

        public User()
        {
            wandelappEntities = new wandelappEntities();
            allUsers = new List<User>();
            userCheck = new bool();
        }

        //public List<User> GetAllUsers() {
        //    var userListDB = wandelappEntities.User.ToList();

        //    foreach (WebAPI.User userDB in userListDB) {
        //        User user = new User() {
        //            username = userDB.username,
        //            password = userDB.password,

        //        };
        //        allUsers.Add(user);
        //    }

        //    return allUsers;
        //}

        public bool CheckUser(User user) {
            TUser userDB = wandelappEntities.TUser.Where(u => u.username == user.username).FirstOrDefault();


            if (userDB != null) { 
                if (user.username == userDB.username && user.password == userDB.password) {
                    userCheck = true;
                }
                else {
                    userCheck = false;
                }
            }

            return userCheck;
        }

        public List<User> getAllUsers()
        {
            List<TUser> userDB = wandelappEntities.TUser.ToList();
            List<User> allUsers = new List<User>();
            foreach (var dbUser in userDB) {
                User user = new User() {
                    username = dbUser.username,
                    password = dbUser.password
                };
                allUsers.Add(user);
            }

            return allUsers;
        }
    }
}