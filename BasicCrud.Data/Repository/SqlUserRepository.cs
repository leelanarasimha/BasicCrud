using System;
using System.Collections.Generic;
using BasicCrud.core;
using BasicCrud.core.Interfaces;
using BasicCrud.core.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BasicCrud.Data.Repository
{
    public class SqlUserRepository : IUserRepository
    {
        private BasicCrudDbContext db { get; }

        public SqlUserRepository(BasicCrudDbContext db)
        {
            this.db = db;
        }


        public User Add(User user)
        {
            db.Users.Add(user);
            return user;
            
        }

        public User Delete(int id)
        {
            var user = GetUserById(id);
            if (user != null) {
                db.Users.Remove(user);
            }
            return user;
            
        }

        public IEnumerable<User> GetAllUsers()
        {
            var query = from user in db.Users
                        orderby user.Name
                        select user;
            return query;
        }

        public User GetUserById(int Id)
        {
            return db.Users.Find(Id);
        }

        public IEnumerable<User> GetUserByName(string Name)
        {
            var query = from user in db.Users
                        where user.Name.Contains(Name)
                        orderby user.Name
                        select user;
            return query;
        }

        public User Update(User user)
        {
            var entity = db.Users.Attach(user);
            entity.State = EntityState.Modified;
            return user;

        }

        public int commit()
        {
            return db.SaveChanges();
        }
    }
}
