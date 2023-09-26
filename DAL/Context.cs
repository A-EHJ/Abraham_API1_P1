using Microsoft.EntityFrameworkCore;

namespace Abraham_API1_P1.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
