﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearningWeb.Controllers
{
    public class FoldersController : Controller
    {
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Intro");
            }
            ViewData["Folder.Name"]="Tiếng anh nâng cao";
            ViewData["Folder.Owner.Username"]="Hải Lương";
            ViewData["Folder.SetCount"]="4";
            ViewData["Folder.Describe"]="Mô tả thư mục ...";

            ViewData["Folder.SetID1.Name"]="Tiếng anh nhập môn";
            ViewData["Folder.SetID1.Count"]="2";
            ViewData["Folder.SetID2.Name"]="Tiếng trung cơ bản";
            ViewData["Folder.SetID2.Count"]="8";
            ViewData["Folder.SetID3.Name"]="Tiếng anh viết và đọc";
            ViewData["Folder.SetID3.Count"]="13";
            ViewData["Folder.SetID4.Name"]="TA chuyên nghành IT";
            ViewData["Folder.SetID4.Count"]="72";
            ViewData["Folder.SetID5.Name"]="Thư viện học thuật";
            ViewData["Folder.SetID5.Count"]="102";
            
            ViewData["User.Username"]="Tuấn Vũ";
            ViewData["User.Avatar"]="resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";

            ViewData["Page.Title"]=ViewData["Folder.Name"];
            ViewData["Page.Target"]="Học phần";
            return View();
        }
    }
}
