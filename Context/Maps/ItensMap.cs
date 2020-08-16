using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCollection.Context.Maps
{
    public class ItensMap : IEntityTypeConfiguration<Itens>
    {
        public void Configure(EntityTypeBuilder<Itens> builder)
        {
            builder.ToTable("Itens");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
        }

    }
}
