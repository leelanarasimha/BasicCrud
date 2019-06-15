using System.Collections.Generic;
using System.Linq;
using BasicCrud.core.Interfaces;
using BasicCrud.core.Models;


namespace BasicCrud.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        
        private List<User> users = new List<User>() {
                new User() { Id=1, Name = "Leela", Email="Leela@gmail.com", Age=12, Location=Location.Bangalore},
                new User() { Id=2, Name = "Naveen", Email = "naveen@gmail.com", Age = 30, Location=Location.Hyderabad },
                new User() { Id=3, Name = "Rama Krishna", Email = "ramakrishna@gmail.com", Age = 30, Location=Location.Guntur }
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

        public User Update(User user)
        {
            var userdetails = users.SingleOrDefault(u => u.Id == user.Id);
            if (userdetails != null) {
                userdetails.Name = user.Name;
                userdetails.Age = user.Age;
                userdetails.Email = user.Email;
                userdetails.Location = user.Location;
            }

            return userdetails;
        }

        public User Add(User user) {
            var id = users.Max(u => u.Id) + 1;
            user.Id = id;
            users.Add(user);
            return user;
        }

        public User Delete(int id)
        {
            var userdetails = users.FirstOrDefault(user => user.Id == id);
            if (userdetails != null) {
                users.Remove(userdetails);
            }
            return userdetails;
        }

        public int commit()
        {
            throw new System.NotImplementedException();
        }

        public int getCount()
        {
            throw new System.NotImplementedException();
        }
    }
}
