using BasicCrud.core;
using BasicCrud.core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicCrud.Pages.Users
{
    public class Edit: PageModel {

        public User UserDetails {get; set;}
        private UserRepository UserRepositoryObj;
        public Edit()
        {
            UserRepositoryObj = new UserRepository();
        }

        public IActionResult OnGet(int userId) {
            UserDetails = UserRepositoryObj.GetUserById(userId);
            if (userId == null) {
                return RedirectToPage("./List");
            }
            return Page();
        }
    }
}