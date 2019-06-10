using BasicCrud.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCrud.core.Repository
{
    public class UserRepository : IUser
    {
        
        private List<User> users = new List<User>() {
                new User() { Id=1, Name = "Leela", Email="Leela@gmail.com", Age=12},
                new User() { Id=2, Name = "Naveen", Email = "naveen@gmail.com", Age = 30 },
                new User() { Id=3, Name = "Rama Krishna", Email = "ramakrishna@gmail.com", Age = 30 }
        };
        
        public IEnumerable<User> GetAllUsers()
        {
            var users = from user in this.users
                        orderby user.Name
                        select user;
            return users;
        }

        public User GetUserById(int Id) {
            return users.SingleOrDefault(user => user.Id == Id);
        }

        public IEnumerable<User> GetUserByName(string Name)
        {
            var users = from user in this.users 
                        where user.Name.Contains(Name)
                        orderby user.Name
                        select user;
            return users;
        }
    }
}
