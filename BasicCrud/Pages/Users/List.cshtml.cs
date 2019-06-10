using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCrud.core;
using BasicCrud.core.Interfaces;
using BasicCrud.core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicCrud.Pages.Users
{
    public class ListModel : PageModel
    {
        public String Message;
        public List<User> users;

        public ListModel()
        {
                
        }

        public void OnGet()
        {
            var usersObj = new UserRepository();
            users = usersObj.GetAllUsers().ToList();
            Message = "Hello Leela";
        }
    }
}