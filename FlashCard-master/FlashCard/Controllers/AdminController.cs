using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Domain.Entities;
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
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Intro");
            }
            var user = _userManager.Data(User.Identity.Name);
            if (!_userManager.IsAdmin(User.Identity.Name))
            {
                return RedirectToAction("Index", "Home");
            }
            ViewData["Admin.User1.ID"]="1";
            ViewData["Admin.User1.Avatar"]="resources/images/user/avt_1.jpg";
            ViewData["Admin.User1.Name"]="Tuấn Vũ";
            ViewData["Admin.User1.CreatedDay"]="04/10/2013";
            ViewData["Admin.User1.Role"]="Quản trị viên";
            ViewData["Admin.User1.Status"]="Hoạt động";

            ViewData["Admin.User2.ID"]="2";
            ViewData["Admin.User2.Avatar"]="resources/images/user/avt_2.jpg";
            ViewData["Admin.User2.Name"]="Hải Lương";
            ViewData["Admin.User2.CreatedDay"]="05/08/2014";
            ViewData["Admin.User2.Role"]="Người dùng";
            ViewData["Admin.User2.Status"]="Hoạt động";
            
            ViewData["Admin.User3.ID"]="3";
            ViewData["Admin.User3.Avatar"]="resources/images/user/avt_3.jpg";
            ViewData["Admin.User3.Name"]="Minh Thiện";
            ViewData["Admin.User3.CreatedDay"]="11/05/2015";
            ViewData["Admin.User3.Role"]="Người dùng";
            ViewData["Admin.User3.Status"]="Hoạt động";

            ViewData["Admin.User4.ID"]="4";
            ViewData["Admin.User4.Avatar"]="resources/images/user/avt_4.jpg";
            ViewData["Admin.User4.Name"]="Lê Huy";
            ViewData["Admin.User4.CreatedDay"]="06/09/2016";
            ViewData["Admin.User4.Role"]="Người dùng";
            ViewData["Admin.User4.Status"]="Hoạt động";

            ViewData["Admin.User5.ID"]="5";
            ViewData["Admin.User5.Avatar"]="resources/images/user/avt_5.jpg";
            ViewData["Admin.User5.Name"]="Thúy Hà";
            ViewData["Admin.User5.CreatedDay"]="12/08/2017";
            ViewData["Admin.User5.Role"]="Người dùng";
            ViewData["Admin.User5.Status"]="Vô hiệu hóa";
            ViewData["Admin.User5.DisableDay"]="18/12/2018";

            ViewData["Page.Title"]="Quản lí tài khoản FlashCard";
            ViewData["Page.Target"]="Tài khoản";
            return View(user);
        }
    }
}
