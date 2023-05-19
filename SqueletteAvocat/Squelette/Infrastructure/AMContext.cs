using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure
{
    public class AMContext: DbContext
    {

        public DbSet<Avocat> Avocats { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dossier> Dossiers { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        //public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=Avocat;MultipleActiveResultSets=true;Integrated Security=true") ;
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AvocatConfiguration());
            modelBuilder.ApplyConfiguration(new DossierConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialiteConfiguration());
            //modelBuilder.ApplyConfiguration(new TicketConfiguration());

            ////TPT
            //modelBuilder.Entity<Staff>().ToTable("Staff");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");

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
