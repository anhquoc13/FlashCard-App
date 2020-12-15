using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Application.Interfaces;
using Application.ViewModels;
using Application.Helpers;
using Domain.Entities;

namespace LearningWeb.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserManager _userManager;
        public AdminController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index(string sortOrder, string userRole, string searchString, int pageIndex = 1)
        {
            if (!_userManager.IsAdmin(User.Identity.Name) || !User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            int pageSize = 5;
            int count;
            var users = _userManager.GetAll(User.Identity.Name, sortOrder, userRole, searchString, pageIndex, pageSize, out count);
            var roles = _userManager.GetRoles();

            var model = new AdminViewModel()
            {
                user = _userManager.GetBy(User.Identity.Name, User.Identity.Name),
                userList = new PaginatedList<User>(users, count, pageIndex, pageSize),
                roles = new SelectList(roles),
                UserRole = userRole,
                SearchString = searchString,
                SortOrder = sortOrder
            };

            ViewData["Page.Title"]="Quản lí tài khoản FlashCard";
            ViewData["Page.Target"]="Tài khoản";
            return View(model);
        }
    }
}
