using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenContext : DbContext
    {
        public DbSet<Citoyen> citoyens { get; set; }
        public DbSet<Vaccin> vaccins { get; set; }
        public DbSet<RendezVous> rendezVous { get; set; }
        public DbSet<CentreVaccination> centreVaccinations { get; set; }
        //public DbSet<Plane> Planes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=ExamenVaccinDB;Integrated Security=true;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CitoyenConfiguration());
            modelBuilder.ApplyConfiguration(new RendezVousConfiguration());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //    // Pre-convention model configuration goes here
            //    configurationBuilder
            //        .Properties<string>()
            //        .HaveMaxLength(50);


            //configurationBuilder
            //    .Properties<decimal>()
            //        .HavePrecision(8,3);


            //configurationBuilder
            //  .Properties<DateTime>()
            //      .HaveColumnType("date");
        }

    }
}
