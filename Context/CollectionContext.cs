using Microsoft.EntityFrameworkCore;

namespace MyCollection
{
    public class CollectionContext : DbContext
    {
        public CollectionContext(DbContextOptions<CollectionContext> options)
            :base(options)
        {}

        #region ContextsClass

        public DbSet<RepositoryLocations> Locations { get; set; }
        public DbSet<Itens> Itens { get; set; }
        public DbSet<Borrowed> Borrowed { get; set; }

        #endregion

    }
}