using System;

namespace structuring_01 {
    public class User {
        public string Username { get; set; }
        public string Password { get; set; }
    
        public User(string username, string password) {
            Username = username;
            Password = password;
        }
    }
}