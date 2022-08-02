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
    }
}
