using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Persistence
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