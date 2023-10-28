using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
