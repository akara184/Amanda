using Microsoft.EntityFrameworkCore;
using Amanda.Domain.Entities;

namespace Amanda.Infrastructure.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {

                u.HasKey(p => p.Id);

                u.Property(p => p.Username).IsRequired();
                u.Property(p => p.Email).IsRequired();

                u.Property(p => p.Password).IsRequired();

                u.HasIndex(p => p.Email).IsUnique();
                u.HasIndex(p => p.Username).IsUnique();

            });
        }



        
    }

} 



// esse base é igual o super em java

// Meu UserDbContext tem um construtor que recebe um parâmetro chamado options. Quando esse construtor for chamad//o, passe esse mesmo options para o construtor da classe pai DbContext. (texto gerado pelo Gemini para entendero base )
