using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCrud.core;
using BasicCrud.core.Interfaces;
using BasicCrud.core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicCrud.Pages.Users
{
    public class ListModel : PageModel
    {
        [TempData]
        public String Message {get; set;}
        public IEnumerable<User> users {get; set;}


        [BindProperty(SupportsGet=true)]
        public string SearchTerm {get; set;}
        private readonly IUserRepository _user;
        public ListModel(IUserRepository UserRepository)
        {
            _user = UserRepository;
        }

       
        public void OnGet()
        {
            
            if (SearchTerm == null) {
                users = _user.GetAllUsers();
            } else {
                users = _user.GetUserByName(SearchTerm);
            }
        }
    }
}