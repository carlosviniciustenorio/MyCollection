using Microsoft.EntityFrameworkCore;
using MyCollection.Models;

namespace MyCollection.Context
{
    public class ContextCT : DbContext
    {
        public ContextCT(DbContextOptions<ContextCT> options)
            :base(options)
        {}

        #region ContextsClass
        public DbSet<User> User { get; set; }
        public DbSet<Itens> Item { get; set; }
        public DbSet<Vinculo> Vinculo { get; set; }

        #endregion

    }
}