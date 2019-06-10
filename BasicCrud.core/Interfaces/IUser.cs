using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrud.core.Interfaces
{
    public interface IUser
    {
        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetUserByName(string Name);
        User GetUserById(int Id);
    }
}
