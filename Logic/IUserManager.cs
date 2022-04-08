using System.Collections.Generic;

namespace Logic
{
    public interface IUserManager
    {
        public List<User> GetUsers();
        public User PostUsers(User user); 
        public User PutUsers(User user);
        public User DeleteUsers(User user);

    }
}