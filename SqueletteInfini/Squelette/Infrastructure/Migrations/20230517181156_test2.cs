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
                name: "FK_Donations_Donators_DonatorFk",
                table: "Donations");

            migrationBuilder.AlterColumn<int>(
                name: "DonatorFk",
                table: "Donations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Donators_DonatorFk",
                table: "Donations",
                column: "DonatorFk",
                principalTable: "Donators",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Donators_DonatorFk",
                table: "Donations");

            migrationBuilder.AlterColumn<int>(
                name: "DonatorFk",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Donators_DonatorFk",
                table: "Donations",
                column: "DonatorFk",
                principalTable: "Donators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
