using Domain.Entities;
using Application.DTO;

namespace Application.ViewModels
{
    public class UserViewModel
    {
        public User user { get; set; }
        public User edit { get; set; }
        public UserDto owner { get; set; }
    }
}