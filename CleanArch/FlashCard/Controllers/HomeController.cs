using FlashCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FlashCard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["User.Username"]="Vũ Đệ";
            ViewData["User.Avatar"]="resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";
            ViewData["User.Role"]="Quản trị viên";

            ViewData["User.SetCount"]="117";
            ViewData["User.FolderCount"]="57";
            ViewData["User.ClassCount"]="7";

            ViewData["Page.Title"]="Vũ Đệ";
            ViewData["Page.Target"]="Trang Chủ";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
