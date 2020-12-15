using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.ViewModels;

namespace LearningWeb.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserManager _userManager;
        public AdminController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            if (!_userManager.IsAdmin(User.Identity.Name) || !User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            AdminViewModel model = new AdminViewModel();
            model.user = _userManager.GetBy(User.Identity.Name, User.Identity.Name);
            model.userList = _userManager.GetAll(User.Identity.Name);

            ViewData["Page.Title"]="Quản lí tài khoản FlashCard";
            ViewData["Page.Target"]="Tài khoản";
            return View(model);
        }
    }
}
