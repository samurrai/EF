using System.Data.Entity;

namespace EntityFramework
{
    public class AppContext : DbContext
    {
        public AppContext() : base("appContext"){}

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
    }
}
