using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrud.core.Interfaces
{
    public interface IUser
    {
        IEnumerable<User> GetAllUsers();
    }
}
