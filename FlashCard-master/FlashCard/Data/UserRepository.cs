using System.Linq;
using FlashCard.Models;
using FlashCard.Models.Repositories;

namespace FlashCard.Data
{
    public class UserRepository : EFRepository<User>, IUserRepository
    {
        public UserRepository(FlashCardContext context) : base(context)
        {
        }

        public User GetBy(string id)
        {
            return Context.User.FirstOrDefault(u => u.ID == id);
        }
    }
}