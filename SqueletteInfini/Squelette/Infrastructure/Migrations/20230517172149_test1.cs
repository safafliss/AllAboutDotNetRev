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
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Donators_DonatorId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_DonatorId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonatorId",
                table: "Donations");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonatorFk",
                table: "Donations",
                column: "DonatorFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Donators_DonatorFk",
                table: "Donations",
                column: "DonatorFk",
                principalTable: "Donators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Donators_DonatorFk",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_DonatorFk",
                table: "Donations");

            migrationBuilder.AddColumn<int>(
                name: "DonatorId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonatorId",
                table: "Donations",
                column: "DonatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Donators_DonatorId",
                table: "Donations",
                column: "DonatorId",
                principalTable: "Donators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
