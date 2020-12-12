using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearningWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["User.Username"]="Tuấn Vũ";
            ViewData["User.Avatar"]="resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";
            ViewData["User.Role"]="Quản trị viên";
            ViewData["User.Country"]="Việt Nam";
            ViewData["User.Job"]="Coder";
            ViewData["User.Bio"]="bla bla bla ...";
            
            ViewData["Team.Name"]="PTTKTeam, Inc";
            ViewData["Team.Avatar"]="resources/images/team/team_1.jpeg";
            ViewData["Team.UserID2.Avatar"]="resources/images/user/avt_2.jpg";
            ViewData["Team.UserID3.Avatar"]="resources/images/user/avt_3.jpg";

            ViewData["Page.Title"]="Tuấn Vũ";
            ViewData["Page.Target"]="Hồ sơ";
            return View();
        }

        public IActionResult Edit()
        {
            ViewData["User.ID"]="1";
            ViewData["User.Username"]="Tuấn Vũ";
            ViewData["User.Tagname"]="tuanvu";
            ViewData["User.Avatar"]="../resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";
            ViewData["User.Role"]="Quản trị viên";
            ViewData["User.Country"]="Việt Nam";
            ViewData["User.Job"]="Coder";
            ViewData["User.Bio"]="bla bla bla ...";

            ViewData["Team.Name"]="PTTKTeam, Inc";

            ViewData["Page.Title"]="Tuấn Vũ";
            ViewData["Page.Target"]="Hồ sơ";
            return View();
        }

        public IActionResult Sets()
        {
            ViewData["User.Username"]="Tuấn Vũ";
            ViewData["User.Avatar"]="../resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";
            ViewData["User.Role"]="Quản trị viên";

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

            ViewData["Page.Title"]="Tuấn Vũ";
            ViewData["Page.Target"]="Học phần";
            return View();
        }

        public IActionResult Folders()
        {
            ViewData["User.Username"]="Tuấn Vũ";
            ViewData["User.Avatar"]="../resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";
            ViewData["User.Role"]="Quản trị viên";

            ViewData["Folder.ID1.Name"]="Tiếng trung cơ bản";
            ViewData["Folder.ID1.Count"]="2";
            ViewData["Folder.ID2.Name"]="Tiếng anh viết và đọc";
            ViewData["Folder.ID2.Count"]="11";

            ViewData["Page.Title"]="Tuấn Vũ";
            ViewData["Page.Target"]="Thư mục";
            return View();
        }

        public IActionResult Classes()
        {
            ViewData["User.Username"]="Tuấn Vũ";
            ViewData["User.Avatar"]="../resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";
            ViewData["User.Role"]="Quản trị viên";

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

            ViewData["Page.Title"]="Tuấn Vũ";
            ViewData["Page.Target"]="Lớp";
            return View();
        }

        public IActionResult AddClass()
        {
            ViewData["User.Username"]="Tuấn Vũ";
            ViewData["User.Avatar"]="../resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";
            ViewData["User.Role"]="Quản trị viên";

            ViewData["Page.Title"]="Tạo lớp";
            ViewData["Page.Target"]=ViewData["Page.Title"];
            return View();
        }
    }
}
