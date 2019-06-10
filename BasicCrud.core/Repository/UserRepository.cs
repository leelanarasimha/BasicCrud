using BasicCrud.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrud.core.Repository
{
    public class UserRepository : IUser
    {
        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>() {
                new User() { Name = "Leela", Email="Leela@gmail.com", Age=12},
                new User() { Name = "Naveen", Email = "naveen@gmail.com", Age = 30 }
        };

            return users;
        }
    }
}
