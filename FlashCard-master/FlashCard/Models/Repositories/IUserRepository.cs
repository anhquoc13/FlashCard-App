using FlashCard.Models;

namespace FlashCard.Models.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetBy(string id);
    }
}