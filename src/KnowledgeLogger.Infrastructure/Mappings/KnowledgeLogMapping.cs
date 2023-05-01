using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeLogger.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KnowledgeLogger.Infrastructure.Mappings
{
    public class KnowledgeLogMapping : IEntityTypeConfiguration<KnowledgeLog>
    {
        public void Configure(EntityTypeBuilder<KnowledgeLog> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(k => k.Title).IsRequired().HasColumnType("varchar(150)");

            builder.Property(k => k.ShortDescription).IsRequired().HasColumnType("varchar(350)");

            builder.Property(k => k.LongDescription).IsRequired(false).HasColumnType("varchar(max)");

            builder.Property(k => k.Author).IsRequired().HasColumnType("varchar(150)");

            builder.Property(k => k.Rating).IsRequired().HasColumnType("decimal(1,1)");

            builder.Property(k => k.Created).IsRequired().HasColumnType("date");

            builder.Property(k => k.Updated).IsRequired().HasColumnType("date");

            builder.Property(k => k.CategoryId).IsRequired().HasColumnType("int");

            builder.ToTable("KnowledgeLogs");
        }
    }
}
