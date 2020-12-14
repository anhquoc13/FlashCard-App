using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Domain.Entities;
using Application.ViewModels;

namespace LearningWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;
        public UserController(IUserManager userManager)
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

            ViewData["User.SetCount"]="117";
            ViewData["User.FolderCount"]="57";
            ViewData["User.ClassCount"]="7";

            ViewData["Page.Title"]=user.ID;
            ViewData["Page.Target"]="Hồ sơ";
            return View(user);
        }

        public IActionResult Edit()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Intro");
            }
            var user = _userManager.Data(User.Identity.Name);

            ViewData["Page.Title"]=user.ID;
            ViewData["Page.Target"]="Hồ sơ";
            return View(user);
        }

        public IActionResult Sets()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Intro");
            }
            var user = _userManager.Data(User.Identity.Name);

            ViewData["Owner.Username"]="Tuấn Vũ";
            ViewData["Owner.Tagname"]="tuanvu";
            ViewData["Owner.Avatar"]="../resources/images/user/avt_1.jpg";
            ViewData["Owner.SetCount"]="117";
            ViewData["Owner.FolderCount"]="57";
            ViewData["Owner.ClassCount"]="7";

            ViewData["Set.ID1.Name"]="Tiếng anh nhập môn";
            ViewData["Set.ID1.Count"]="2";
            ViewData["Set.ID2.Name"]="Tiếng trung cơ bản";
            ViewData["Set.ID2.Count"]="8";
            ViewData["Set.ID3.Name"]="Tiếng anh viết và đọc";
            ViewData["Set.ID3.Count"]="13";
            ViewData["Set.ID4.Name"]="TA chuyên nghành IT";
            ViewData["Set.ID4.Count"]="72";
            ViewData["Set.ID5.Name"]="Thư viện học thuật";
            ViewData["Set.ID5.Count"]="102";

            ViewData["Page.Title"]=user.ID;
            ViewData["Page.Target"]="Học phần";
            return View(user);
        }

        public IActionResult Folders()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Intro");
            }
            var user = _userManager.Data(User.Identity.Name);

            ViewData["Owner.Username"]="Tuấn Vũ";
            ViewData["Owner.Tagname"]="tuanvu";
            ViewData["Owner.Avatar"]="../resources/images/user/avt_1.jpg";
            ViewData["Owner.SetCount"]="117";
            ViewData["Owner.FolderCount"]="57";
            ViewData["Owner.ClassCount"]="7";

            ViewData["Folder.ID1.Name"]="Tiếng trung cơ bản";
            ViewData["Folder.ID1.Count"]="2";
            ViewData["Folder.ID2.Name"]="Tiếng anh viết và đọc";
            ViewData["Folder.ID2.Count"]="11";

            ViewData["Page.Title"]=user.ID;
            ViewData["Page.Target"]="Thư mục";
            return View(user);
        }

        public IActionResult Classes()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Intro");
            }
            var user = _userManager.Data(User.Identity.Name);

            ViewData["Owner.Username"]="Tuấn Vũ";
            ViewData["Owner.Tagname"]="tuanvu";
            ViewData["Owner.Avatar"]="../resources/images/user/avt_1.jpg";
            ViewData["Owner.SetCount"]="117";
            ViewData["Owner.FolderCount"]="57";
            ViewData["Owner.ClassCount"]="7";

            ViewData["Class.ID1.Name"]="Lớp tiếng trung cơ bản";
            ViewData["Class.ID1.setID.Count"]="2";
            ViewData["Class.ID1.userID.Count"]="11";
            ViewData["Class.ID1.School"]="SGUL • Ho Chi Minh City, Viet Nam";
            ViewData["Class.ID2.Name"]="Lớp tiếng anh viết và đọc thầy Huy";
            ViewData["Class.ID2.setID.Count"]="1";
            ViewData["Class.ID2.userID.Count"]="3";
            ViewData["Class.ID2.School"]="SGUL • Ho Chi Minh City, Viet Nam";
            ViewData["Class.ID3.Name"]="Lớp 116A - Đại học Sài Gòn SGU";
            ViewData["Class.ID3.setID.Count"]="87";
            ViewData["Class.ID3.userID.Count"]="110";
            ViewData["Class.ID3.School"]="SGUL • Ho Chi Minh City, Viet Nam";

            ViewData["Page.Title"]=user.ID;
            ViewData["Page.Target"]="Lớp";
            return View(user);
        }

        public IActionResult AddSet()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Intro");
            }
            var user = _userManager.Data(User.Identity.Name);

            ViewData["Page.Title"]=user.ID;
            ViewData["Page.Target"]="Tạo học phần";
            return View();
        }

        public IActionResult AddClass()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Intro");
            }
            var user = _userManager.Data(User.Identity.Name);

            ViewData["Page.Title"]=user.ID;
            ViewData["Page.Target"]="Tạo học phần";
            return View(user);
        }
    }
}
