
using Contatos.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace Contatos.Infra.Context
{
    public class AppDbContext : DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }
    }
}