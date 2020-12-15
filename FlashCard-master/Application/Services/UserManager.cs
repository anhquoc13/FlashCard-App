using System.Collections.Generic;
using Application.DTO;
using Application.Interfaces;
using Application.Mappings;
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

        public User Create(UserDto temp, string email, string password)
        {
            User user = temp.MappingUser();
            user.email = email;
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

        public UserDto GetBy(string id)
        {
            return _userRepository.GetBy(id).MappingDto();
        }

        public User GetBy(string id, string accessID)
        {
            if (IsAdmin(accessID))
            {
                return _userRepository.GetBy(id);
            }
            return _userRepository.GetBy(accessID);
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _userRepository.GetAll().MappingDto();
        }

        public IEnumerable<User> GetAll(string accessID)
        {
            if (IsAdmin(accessID))
            {
                return _userRepository.GetAll();
            }
            return _userRepository.GetAll().MappingDto().MappingUser();
        }

        public UserDto GetOwner(string id)
        {
            return _userRepository.GetBy(id).MappingDto();
        }

        public bool IsAdmin(string id)
        {
            return _userRepository.GetBy(id).role == "Quản trị viên";
        }

        public bool IsActive(string id)
        {
            return _userRepository.GetBy(id).status == 1;
        }
    }
}