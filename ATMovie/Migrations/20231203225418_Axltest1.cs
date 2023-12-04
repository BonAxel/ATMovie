using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class Axltest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Row_Salon_SalonID",
                table: "Row");

            migrationBuilder.DropIndex(
                name: "IX_Row_SalonID",
                table: "Row");

            migrationBuilder.DropColumn(
                name: "SalonID",
                table: "Row");

            migrationBuilder.AddColumn<int>(
                name: "SalonID",
                table: "Seat",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seat_SalonID",
                table: "Seat",
                column: "SalonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Salon_SalonID",
                table: "Seat",
                column: "SalonID",
                principalTable: "Salon",
                principalColumn: "SalonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Salon_SalonID",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Seat_SalonID",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "SalonID",
                table: "Seat");

            migrationBuilder.AddColumn<int>(
                name: "SalonID",
                table: "Row",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Row_SalonID",
                table: "Row",
                column: "SalonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Row_Salon_SalonID",
                table: "Row",
                column: "SalonID",
                principalTable: "Salon",
                principalColumn: "SalonID");
        }
    }
}
