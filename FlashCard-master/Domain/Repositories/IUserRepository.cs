using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetBy(string id);
    }
}