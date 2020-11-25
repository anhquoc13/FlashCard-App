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

            ViewData["Set.ID1.Name"]="Tiếng anh luyện viết";
            ViewData["Set.ID1.Count"]="3";
            ViewData["Set.ID1.Image"]="https://cdn.pixabay.com/photo/2018/03/30/15/11/deer-3275594_960_720.jpg";
            ViewData["Set.ID2.Name"]="Tiếng anh căn bản";
            ViewData["Set.ID2.Count"]="7";
            ViewData["Set.ID2.Image"]="https://cdn.pixabay.com/photo/2018/04/09/19/55/low-poly-3305284_960_720.jpg";
            ViewData["Set.ID3.Name"]="Tiếng anh nâng cao";
            ViewData["Set.ID3.Count"]="15";
            ViewData["Set.ID3.Image"]="https://cdn.pixabay.com/photo/2018/04/06/13/46/poly-3295856_960_720.png";
            ViewData["Set.ID4.Name"]="Tiếng trung căn bản";
            ViewData["Set.ID4.Count"]="4";
            ViewData["Set.ID4.Image"]="https://cdn.pixabay.com/photo/2018/03/30/15/12/dog-3275593_960_720.jpg";

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
