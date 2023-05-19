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

        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Clinique> Cliniques { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=CliniqueDB;MultipleActiveResultSets=true;Integrated Security=true") ;
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new CliniqueConfiguration());
            modelBuilder.ApplyConfiguration(new AdmissionConfiguration());
            foreach (var item in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties().Where(p=>p.ClrType == typeof(string)))) {
                item.IsNullable = false;
            } ;
            //modelBuilder.ApplyConfiguration(new FlightConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //modelBuilder.ApplyConfiguration(new TicketConfiguration());

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
