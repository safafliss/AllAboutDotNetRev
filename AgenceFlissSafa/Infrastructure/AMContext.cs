﻿using ApplicationCore.Domain;
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

        public DbSet<Conseiller> Conseillers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Activite> Activites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=AgenceFlissSafaDB;MultipleActiveResultSets=true;Integrated Security=true") ;
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguartion());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            foreach (var item in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                item.SetMaxLength(25);
            };
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //modelBuilder.ApplyConfiguration(new TicketConfiguration());

            //modelBuilder.Entity<Staff>().ToTable("Staff");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //    // Pre-convention model configuration goes here
            configurationBuilder
                .Properties<string>()
                .HaveMaxLength(25);
            //configurationBuilder
            //    .Properties<decimal>()
            //        .HavePrecision(8,3);
            //configurationBuilder
            //  .Properties<DateTime>()
            //      .HaveColumnType("date");
        }



    }
}
