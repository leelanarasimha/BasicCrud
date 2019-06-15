using BasicCrud.core.Interfaces;
using BasicCrud.core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicCrud.Pages.Users
{
    public class Delete : PageModel
    {
        private IUserRepository _userRepository;

        public User userData;

        public Delete(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult OnGet(int userId)
        {
            userData = _userRepository.GetUserById(userId);
            if (userData == null)
            {
                TempData["Message"] = "User doesnt exist";
                return RedirectToPage("./List");
            }

            return Page();
        }


        public IActionResult OnPost(int userId)
        {
            _userRepository.Delete(userId);
            _userRepository.commit();
            TempData["Message"] = "User deleted successfully";
            return RedirectToPage("./List");
        }
    }
}