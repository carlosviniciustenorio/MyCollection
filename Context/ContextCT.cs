using Microsoft.EntityFrameworkCore;
using MyCollection.Context.Maps;
using MyCollection.Models;

namespace MyCollection.Context
{
    public class ContextCT : DbContext
    {
        public ContextCT(DbContextOptions<ContextCT> options)
            :base(options)
        {}

        public DbSet<User> User { get; set; }
        public DbSet<Itens> Item { get; set; }
        public DbSet<Vinculo> Vinculo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new ItensMap());
        }        

    }
}