using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager : IUserManager
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
            User userfound = Users.Find(u => u.Ci == user.Ci);
            if (userfound == null)
            {
                Users.Add(user);
                return user;
            }
            return null;
        }
        public User PutUsers(User user)
        {
            User userToUpdate = Users.Find(x => x.Ci == user.Ci);
            if (userToUpdate != null)
            {
                userToUpdate.Name = user.Name;
                userToUpdate.Ci = user.Ci;
                return user;
            }
            return null;
        }
        public User DeleteUsers(User user)
        {
            User userfound = Users.Find(u => u.Name == user.Name);
            Users.Remove(userfound);
            return userfound;
        }


    }

    
}
