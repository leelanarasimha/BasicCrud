using System.Collections.Generic;
using BasicCrud.core;
using BasicCrud.core.Interfaces;
using BasicCrud.core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BasicCrud.Pages.Users
{
    public class Edit : PageModel
    {
        [BindProperty] public User UserDetails { get; set; }
        public IEnumerable<SelectListItem> locations;
        private readonly IUserRepository _user;
        private readonly IHtmlHelper _htmlhelper;

        public Edit(IUserRepository user, IHtmlHelper htmlhelper)
        {
            _user = user;
            _htmlhelper = htmlhelper;
            locations = _htmlhelper.GetEnumSelectList<Location>();
        }

        public IActionResult OnGet(int? userId)
        {
            if (userId.HasValue)
            {
                UserDetails = _user.GetUserById(userId.Value);
            }
            else
            {
                UserDetails = new User();
            }

            if (UserDetails == null)
            {
                return RedirectToPage("./List");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (UserDetails.Id <= 0)
            {
                TempData["Message"] = "User Created Successfully";
                UserDetails = _user.Add(UserDetails);
            }
            else
            {
                TempData["Message"] = "User Updated Successfully";
                UserDetails = _user.Update(UserDetails);
            }

            return RedirectToPage("./List");
        }
    }
}