using System.Threading.Tasks;
using FlashCard.Models;

namespace FlashCard.Interfaces
{
    public interface ISignInManager
    {
        Task SignInAsync(User user, bool isPersistent);
        Task<bool> PasswordSignInAsync(string id, string password, bool isPersistent);
    }
}