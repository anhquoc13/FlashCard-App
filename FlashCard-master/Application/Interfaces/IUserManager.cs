using System.Collections.Generic;
using Application.DTO;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUserManager
    {
        bool UserExists(string id);
        User Data(string id);
        User Create(User user, string password);
    }
}