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

    }
} 


// esse base é igual o super em java

// Meu UserDbContext tem um construtor que recebe um parâmetro chamado options. Quando esse construtor for chamad//o, passe esse mesmo options para o construtor da classe pai DbContext. (texto gerado pelo Gemini)
