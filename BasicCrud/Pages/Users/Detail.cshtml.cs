using BasicCrud.core;
using BasicCrud.core.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicCrud.Pages.Users
{
    public class Detail : PageModel
    {

        public User User {get; set;}

        private readonly UserRepository userRepositoryObj;

        public Detail()
        {
            userRepositoryObj = new UserRepository();
        }
        
        public IActionResult OnGet(int userId)
        {
            this.User =  userRepositoryObj.GetUserById(userId);
            if (this.User == null) {
                return RedirectToPage("./List");
            }
            return Page();
        }
    }
}