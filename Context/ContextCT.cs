using Microsoft.EntityFrameworkCore;
using MyCollection.Models;
using MyCollection.Repository;

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

        #endregion

    }
}