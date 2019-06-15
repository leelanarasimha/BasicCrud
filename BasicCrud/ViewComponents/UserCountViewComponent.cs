using BasicCrud.core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BasicCrud.ViewComponents
{
    public class UserCountViewComponent : ViewComponent
    {
        private IUserRepository _userData;

        public UserCountViewComponent(IUserRepository userRepository)
        {
            _userData = userRepository;
        }

        public IViewComponentResult Invoke()
        {
            var count = _userData.getCount();
            return View(count);
        }

    }
}