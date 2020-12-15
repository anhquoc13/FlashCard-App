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
        IEnumerable<UserDto> GetAll();
        IEnumerable<User> GetAll(string accessID);
        UserDto GetOwner(string id);
        bool UserExists(string id);
        bool IsAdmin(string id);
        bool IsActive(string id);
    }
}