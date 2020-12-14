using System.Collections.Generic;
using Application.DTO;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUserManager
    {
        bool UserExists(string id);
        UserDto Data(string id);
        bool IsAdmin(string id);
        User Create(UserDto user, string password);
    }
}