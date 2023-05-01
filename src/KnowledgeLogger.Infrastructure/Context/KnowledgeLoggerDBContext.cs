using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeLogger.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeLogger.Infrastructure.Context
{
    public class KnowledgeLoggerDBContext : DbContext
    {
        public KnowledgeLoggerDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<KnowledgeLog> KnowledgeLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // optional as you have already set the size for all the string fields in KnowledgeLogMapping and CategoryMapping
            /*
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string)))) 
                 property.SetColumnType("varchar(150)");
            */

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KnowledgeLoggerDBContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
