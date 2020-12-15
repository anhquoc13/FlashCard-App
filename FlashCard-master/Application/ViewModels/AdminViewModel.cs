using Domain.Entities;
using System.Collections.Generic;

namespace Application.ViewModels
{
    public class AdminViewModel
    {
        public User user { get; set; }
        public IEnumerable<User> userList { get; set; }
    }
}