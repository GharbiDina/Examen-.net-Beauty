using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrastructure
{
    public class ExamContext: DbContext
    { public DbSet<Client> Client { get; set; }
 public DbSet<Prestation> Prestation { get; set; }
 public DbSet<Prestataire> Prestataire { get; set; }
 public DbSet<RDV> RDV { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;

             Initial Catalog=Beautydina;Integrated Security=true;
                  MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {modelBuilder.ApplyConfiguration(new RDVConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {         configurationBuilder.Properties<string>().HaveMaxLength(150);
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
