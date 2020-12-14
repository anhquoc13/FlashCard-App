using System.Collections.Generic;
using Application.DTO;
using Application.Interfaces;
using Domain.Repositories;
using Domain.Entities;

namespace Application.Services
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create(User user, string password)
        {
            user.passwd = password;
            user.contry = "Việt Nam";
            user.avatar = "../resources/images/user/avt_hidden.jpg";
            user.role = "Thành viên";
            user.createdDay = System.DateTime.Today.ToString("dd-MM-yyyy");
            user.status = 1;
            _userRepository.Add(user);

            return user;
        }

        public bool UserExists(string id)
        {
            var user = _userRepository.GetBy(id);

            return user != null;
        }

        public User Data(string id)
        {
            var user = _userRepository.GetBy(id);
            return user;
        }
    }
}