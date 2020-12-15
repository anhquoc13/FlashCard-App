using System.Collections.Generic;
using Application.DTO;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUserManager
    {
        User Create(UserDto user, string email, string password);
        UserDto GetBy(string id);
        User GetBy(string id, string accessID);
        UserDto GetOwner(string id);
        IEnumerable<UserDto> GetAll();
        IEnumerable<User> GetAll(string accessID, string sortOrder, string userRole, string searchString, int pageIndex, int pageSize, out int count);
        IEnumerable<string> GetRoles();
        void UpdateUser(UserDto userDto);
        void DeleteUser(string id);
        bool UserExists(string id);
        bool IsAdmin(string id);
        bool IsActive(string id);
    }
}