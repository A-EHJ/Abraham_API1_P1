using Microsoft.EntityFrameworkCore;
using Abraham_API1_P1.Models;
namespace Abraham_API1_P1.DAL
{
    public class Context : DbContext
    {
        public DbSet<Aportes> Aportes { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
