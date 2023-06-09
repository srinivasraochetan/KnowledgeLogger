﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeLogger.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KnowledgeLogger.Infrastructure.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasColumnType("varchar(150)");

            // 1 : N => Category : KnowledgeLog
            builder.HasMany(c => c.KnowledgeLog).WithOne(k => k.Category).HasForeignKey(k => k.CategoryId);

            builder.ToTable("Categories");
        }
    }
}
