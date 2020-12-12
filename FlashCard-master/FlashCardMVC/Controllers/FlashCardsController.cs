using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearningWeb.Controllers
{
    public class FlashCardsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Set.Name"]="Tiếng anh nâng cao";
            ViewData["Set.Owner.Username"]="Hải Lương";
            ViewData["Set.Owner.Avatar"]="resources/images/user/avt_2.jpg";
            ViewData["Set.Describe"]="Mô tả ...";

            ViewData["Set.Card1.Term"]="Hello";
            ViewData["Set.Card1.Definition"]="Xin chào";
            ViewData["Set.Card2.Term"]="Goodbye";
            ViewData["Set.Card2.Definition"]="Tạm biệt";
            ViewData["Set.Card3.Term"]="Apple";
            ViewData["Set.Card3.Definition"]="Quả táo";

            ViewData["Folder.SetID.Name1"]="TA IT";
            ViewData["Folder.SetID.Name2"]="Tiếng anh Basic";
            
            ViewData["User.Username"]="Tuấn Vũ";
            ViewData["User.Avatar"]="resources/images/user/avt_1.jpg";
            ViewData["User.Email"]="abc@gmail.com";
            ViewData["User.Role"]="Quản trị viên";
            ViewData["User.Country"]="Việt Nam";
            ViewData["User.Job"]="Coder";
            ViewData["User.Teamname"]="PTTKTeam, Inc";
            ViewData["User.Avatar-Team"]="resources/images/team/team_1.jpeg";
            ViewData["User.Bio"]="bla bla bla ...";

            ViewData["Page.Title"]=ViewData["Set.Name"];
            ViewData["Page.Target"]="Học phần";
            return View();
        }
    }
}
