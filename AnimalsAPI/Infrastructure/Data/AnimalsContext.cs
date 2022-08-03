using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AnimalsContext : DbContext
    {
        public DbSet<Animal> animals { get; set; }
        public AnimalsContext(DbContextOptions options) : base(options)
        {

        }
        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is AuditableEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((AuditableEntity)entityEntry.Entity).lastModified = DateTime.UtcNow;

                if (entityEntry.State == EntityState.Added)
                {
                    ((AuditableEntity)entityEntry.Entity).created = DateTime.UtcNow;
                }
            }

            return base.SaveChanges();
        }
    }
}

