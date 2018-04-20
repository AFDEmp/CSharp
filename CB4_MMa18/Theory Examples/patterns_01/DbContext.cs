using System.Collections.Generic;
using System;

namespace structuring_01
{
    public class DbContext : IDisposable {
        public List<User> Users { get; set; } = new List<User>() {
            new User("User1", "12345"),
            new User("User2", "12345")
        };

        public void Dispose()
        {           
        }
    }
}