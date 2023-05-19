using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficiaries",
                columns: table => new
                {
                    CIN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaries", x => x.CIN);
                });

            migrationBuilder.CreateTable(
                name: "Donators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DonatorId = table.Column<int>(type: "int", nullable: false),
                    DonatorFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donations_Donators_DonatorId",
                        column: x => x.DonatorId,
                        principalTable: "Donators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kafalas",
                columns: table => new
                {
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BeneficiaryFk = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DonatorFk = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kafalas", x => new { x.StartDate, x.BeneficiaryFk, x.DonatorFk });
                    table.ForeignKey(
                        name: "FK_Kafalas_Beneficiaries_BeneficiaryFk",
                        column: x => x.BeneficiaryFk,
                        principalTable: "Beneficiaries",
                        principalColumn: "CIN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kafalas_Donators_DonatorFk",
                        column: x => x.DonatorFk,
                        principalTable: "Donators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonatorId",
                table: "Donations",
                column: "DonatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Kafalas_BeneficiaryFk",
                table: "Kafalas",
                column: "BeneficiaryFk");

            migrationBuilder.CreateIndex(
                name: "IX_Kafalas_DonatorFk",
                table: "Kafalas",
                column: "DonatorFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Kafalas");

            migrationBuilder.DropTable(
                name: "Beneficiaries");

            migrationBuilder.DropTable(
                name: "Donators");
        }
    }
}
