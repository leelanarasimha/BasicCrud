using BasicCrud.core;
using BasicCrud.core.Interfaces;
using BasicCrud.core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicCrud.Pages.Users
{
    public class Edit: PageModel {

        [BindProperty]
        public User UserDetails {get; set;}
        private IUser _user;
        public Edit(IUser user)
        {
            _user = user;
        }

        public IActionResult OnGet(int userId) {
            UserDetails = _user.GetUserById(userId);
            if (UserDetails == null) {
                return RedirectToPage("./List");
            }
            return Page();
        }

        public IActionResult OnPost() {
            UserRepositoryObj.

            return Page();
        }
    }
}