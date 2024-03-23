using Microsoft.EntityFrameworkCore;
namespace Mission_11_jefferson_lambert.Models
{
    // DBBOOKCONTEXT being set up for reference in various other places
    public class DBBookContext : DbContext
    {
        public DBBookContext(DbContextOptions<DBBookContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
