using Microsoft.EntityFrameworkCore;
using FlashCard.Models;

namespace FlashCard.Data
{
    public class FlashCardContext : DbContext
    {
        public FlashCardContext(DbContextOptions<FlashCardContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}