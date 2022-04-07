using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager
    {
        public List<User> Users { get; set; }

        public UserManager()
        {
            Users = new List<User>()
            {
                new User() { Ci = 75461, Name = "Luis"},
                new User() { Ci = 29101, Name = "Fernando"},
                new User() { Ci = 17156, Name = "Karen"},
                new User() { Ci = 54297, Name = "Rene"},
            };
        }
        public List<User> GetUsers()
        {
            return Users;
        }
        public User PostUsers(User user)
        {
            Users.Add(user);
            return user;
        }

    }
}
