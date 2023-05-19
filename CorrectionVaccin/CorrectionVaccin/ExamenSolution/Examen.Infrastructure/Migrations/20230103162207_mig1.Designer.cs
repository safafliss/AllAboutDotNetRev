﻿// <auto-generated />
using System;
using Examen.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    [DbContext(typeof(ExamenContext))]
    [Migration("20230103162207_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Examen.ApplicationCore.Domain.CentreVaccination", b =>
                {
                    b.Property<int>("CentreVaccinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CentreVaccinationId"), 1L, 1);

                    b.Property<int>("Capacite")
                        .HasColumnType("int");

                    b.Property<int>("NbChaises")
                        .HasColumnType("int");

                    b.Property<int>("NumTelephone")
                        .HasColumnType("int");

                    b.Property<string>("ResponsableCentre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CentreVaccinationId");

                    b.ToTable("centreVaccinations");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Citoyen", b =>
                {
                    b.Property<string>("CIN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CitoyenId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroEvax")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("CIN");

                    b.ToTable("citoyens");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.RendezVous", b =>
                {
                    b.Property<string>("CitoyenId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("VaccinId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateVaccination")
                        .HasColumnType("datetime2");

                    b.Property<string>("CodeInfirmiere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbrDoses")
                        .HasColumnType("int");

                    b.HasKey("CitoyenId", "VaccinId", "DateVaccination");

                    b.HasIndex("VaccinId");

                    b.ToTable("rendezVous");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Vaccin", b =>
                {
                    b.Property<int>("VaccinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VaccinId"), 1L, 1);

                    b.Property<int?>("CentreVaccinationId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateValidite")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fournisseur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.Property<int>("TypeVaccin")
                        .HasColumnType("int");

                    b.Property<string>("Validité")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaccinId");

                    b.HasIndex("CentreVaccinationId");

                    b.ToTable("vaccins");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Citoyen", b =>
                {
                    b.OwnsOne("Examen.ApplicationCore.Domain.Addresse", "Addresse", b1 =>
                        {
                            b1.Property<string>("CitoyenCIN")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("CodePostal")
                                .HasColumnType("int");

                            b1.Property<int>("Rue")
                                .HasColumnType("int");

                            b1.Property<string>("Ville")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CitoyenCIN");

                            b1.ToTable("citoyens");

                            b1.WithOwner()
                                .HasForeignKey("CitoyenCIN");
                        });

                    b.Navigation("Addresse")
                        .IsRequired();
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.RendezVous", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Citoyen", "citoyen")
                        .WithMany("rendezVous")
                        .HasForeignKey("CitoyenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.Vaccin", "vaccin")
                        .WithMany("rendezVous")
                        .HasForeignKey("VaccinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("citoyen");

                    b.Navigation("vaccin");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Vaccin", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.CentreVaccination", "centrevaccination")
                        .WithMany("vaccins")
                        .HasForeignKey("CentreVaccinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("centrevaccination");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.CentreVaccination", b =>
                {
                    b.Navigation("vaccins");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Citoyen", b =>
                {
                    b.Navigation("rendezVous");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Vaccin", b =>
                {
                    b.Navigation("rendezVous");
                });
#pragma warning restore 612, 618
        }
    }
}
