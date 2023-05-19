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

        public DbSet<Donator> Donators { get; set; }
        public DbSet<Kafala> Kafalas { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        //public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=SolutionDB;MultipleActiveResultSets=true;Integrated Security=true") ;
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KafalaConfiguration());
            //modelBuilder.ApplyConfiguration(new FlightConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
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
