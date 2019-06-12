using System;
using System.Collections.Generic;
using System.Text;
using BasicCrud.Data.Models;

namespace BasicCrud.core.Interfaces
{
    public interface IUserRepository
    {


        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetUserByName(string Name);
        User GetUserById(int Id);
        User Add(User user);
        User Update(User user);
    }
}
