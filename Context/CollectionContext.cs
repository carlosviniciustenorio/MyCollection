using Microsoft.EntityFrameworkCore;

namespace MyCollection
{
    public class CollectionContext : DbContext
    {
        public CollectionContext(DbContextOptions<CollectionContext> options)
            :base(options)
        {}

        public DbSet<Locations> Locations { get; set; }
        public DbSet<Itens> Itens { get; set; }
        public DbSet<Borrowed> Borrowed { get; set; }

    }
}