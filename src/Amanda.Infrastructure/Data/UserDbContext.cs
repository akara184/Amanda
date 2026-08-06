using Microsoft.EntityFrameworkCore;
using Amanda.Domain.Entities;

namespace Amanda.Infrastructure.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options){
        }

        public DbSet<User> Users { get; set; }

    }
} 
