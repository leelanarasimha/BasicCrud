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
        public String Message {get; set;}
        public IEnumerable<User> users {get; set;}


        [BindProperty(SupportsGet=true)]
        public string SearchTerm {get; set;}

       
        public void OnGet()
        {
            var usersObj = new UserRepository();
            if (SearchTerm == null) {
                users = usersObj.GetAllUsers();
            } else {
                users = usersObj.GetUserByName(SearchTerm);
            }
        }
    }
}