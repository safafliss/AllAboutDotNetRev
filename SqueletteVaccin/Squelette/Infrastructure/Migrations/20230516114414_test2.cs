using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccins_CentreVaccinations_CentreVaccinationFk",
                table: "Vaccins");

            migrationBuilder.AlterColumn<int>(
                name: "CentreVaccinationFk",
                table: "Vaccins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccins_CentreVaccinations_CentreVaccinationFk",
                table: "Vaccins",
                column: "CentreVaccinationFk",
                principalTable: "CentreVaccinations",
                principalColumn: "CentreVaccinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccins_CentreVaccinations_CentreVaccinationFk",
                table: "Vaccins");

            migrationBuilder.AlterColumn<int>(
                name: "CentreVaccinationFk",
                table: "Vaccins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccins_CentreVaccinations_CentreVaccinationFk",
                table: "Vaccins",
                column: "CentreVaccinationFk",
                principalTable: "CentreVaccinations",
                principalColumn: "CentreVaccinationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
