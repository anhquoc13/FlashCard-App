using FlashCard.Models;

namespace FlashCard.Interfaces
{
    public interface IUserManager
    {
        bool UserExists(string id);
        User Create(User user, string password);
    }
}