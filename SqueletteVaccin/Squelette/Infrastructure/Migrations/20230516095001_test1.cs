using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentreVaccinations",
                columns: table => new
                {
                    CentreVaccinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacite = table.Column<int>(type: "int", nullable: false),
                    NbChaises = table.Column<int>(type: "int", nullable: false),
                    NumTelephone = table.Column<int>(type: "int", nullable: false),
                    ResponsableCentre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentreVaccinations", x => x.CentreVaccinationId);
                });

            migrationBuilder.CreateTable(
                name: "Citoyens",
                columns: table => new
                {
                    CIN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Addresse_CodePostal = table.Column<int>(type: "int", nullable: false),
                    Addresse_Rue = table.Column<int>(type: "int", nullable: false),
                    Addresse_Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CitoyenId = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroEvax = table.Column<int>(type: "int", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citoyens", x => x.CIN);
                });

            migrationBuilder.CreateTable(
                name: "Vaccins",
                columns: table => new
                {
                    VaccinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateValidite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fournisseur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    TypeVaccin = table.Column<int>(type: "int", nullable: false),
                    CentreVaccinationFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccins", x => x.VaccinId);
                    table.ForeignKey(
                        name: "FK_Vaccins_CentreVaccinations_CentreVaccinationFk",
                        column: x => x.CentreVaccinationFk,
                        principalTable: "CentreVaccinations",
                        principalColumn: "CentreVaccinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rendezs",
                columns: table => new
                {
                    DateVaccination = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaccinId = table.Column<int>(type: "int", nullable: false),
                    CitoyenId = table.Column<int>(type: "int", nullable: false),
                    CodeInfirmiere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NbrDoses = table.Column<int>(type: "int", nullable: false),
                    CitoyenCIN = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rendezs", x => new { x.CitoyenId, x.VaccinId, x.DateVaccination });
                    table.ForeignKey(
                        name: "FK_Rendezs_Citoyens_CitoyenCIN",
                        column: x => x.CitoyenCIN,
                        principalTable: "Citoyens",
                        principalColumn: "CIN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rendezs_Vaccins_VaccinId",
                        column: x => x.VaccinId,
                        principalTable: "Vaccins",
                        principalColumn: "VaccinId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rendezs_CitoyenCIN",
                table: "Rendezs",
                column: "CitoyenCIN");

            migrationBuilder.CreateIndex(
                name: "IX_Rendezs_VaccinId",
                table: "Rendezs",
                column: "VaccinId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccins_CentreVaccinationFk",
                table: "Vaccins",
                column: "CentreVaccinationFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rendezs");

            migrationBuilder.DropTable(
                name: "Citoyens");

            migrationBuilder.DropTable(
                name: "Vaccins");

            migrationBuilder.DropTable(
                name: "CentreVaccinations");
        }
    }
}
