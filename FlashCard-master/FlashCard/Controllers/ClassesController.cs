﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearningWeb.Controllers
{
    public class ClassesController : Controller
    {
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Intro");
            }
            ViewData["Class.Name"]="Lớp 116A - Đại học Sài Gòn SGU";
            ViewData["Class.School"]="SGUL • Ho Chi Minh City, Viet Nam";
            ViewData["Class.Link"]="https://flashcard.com/join/T7cMjJefS";
            ViewData["Class.SetCount"]="3";
            ViewData["Class.MemberCount"]="4";
            ViewData["Class.Describe"]="Mô tả lớp ...";

            ViewData["Class.SetID1.Name"]="Tiếng anh nhập môn";
            ViewData["Class.SetID1.Count"]="2";
            ViewData["Class.SetID1.OwnerID.Username"]="Hải Lương";
            ViewData["Class.SetID1.OwnerID.Avatar"]="resources/images/user/avt_2.jpg";
            ViewData["Class.SetID2.Name"]="Tiếng anh giao tiếp";
            ViewData["Class.SetID2.Count"]="7";
            ViewData["Class.SetID2.OwnerID.Username"]="Minh Thiện";
            ViewData["Class.SetID2.OwnerID.Avatar"]="resources/images/user/avt_3.jpg";

            ViewData["Class.Member1.Name"]="Tuấn Vũ";
            ViewData["Class.Member1.Role"]="Quản trị viên";
            ViewData["Class.Member1.Avatar"]="resources/images/user/avt_1.jpg";
            ViewData["Class.Member2.Name"]="Hải Lương";
            ViewData["Class.Member2.Role"]="Thành viên";
            ViewData["Class.Member2.Avatar"]="resources/images/user/avt_2.jpg";
            ViewData["Class.Member3.Name"]="Minh Thiện";
            ViewData["Class.Member3.Role"]="Thành Viên";
            ViewData["Class.Member3.Avatar"]="resources/images/user/avt_3.jpg";
            ViewData["Class.Member4.Name"]="Lê Huy";
            ViewData["Class.Member4.Role"]="Thành Viên";
            ViewData["Class.Member4.Avatar"]="resources/images/user/avt_4.jpg";

            ViewData["Class.FolderID1.Name"]="Tiếng anh viết và đọc";
            ViewData["Class.FolderID1.Count"]="11";
            
            ViewData["User.Username"]="Tuấn Vũ";
            ViewData["User.Avatar"]="resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";

            ViewData["Page.Title"]=ViewData["Class.Name"];
            ViewData["Page.Target"]="Học phần";
            return View();
        }
    }
}
