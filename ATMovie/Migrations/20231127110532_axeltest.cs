using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class axeltest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Seat_SeatID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Show_ShowID1",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ShowID1",
                table: "Booking");

            migrationBuilder.DeleteData(
                table: "Show",
                keyColumn: "ShowID",
                keyValue: "S1");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Show");

            migrationBuilder.DropColumn(
                name: "RowId",
                table: "Salon");

            migrationBuilder.DropColumn(
                name: "ShowID1",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "SeatID",
                table: "Booking",
                newName: "SeatId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_SeatID",
                table: "Booking",
                newName: "IX_Booking_SeatId");

            migrationBuilder.AlterColumn<string>(
                name: "ShowID",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalonID",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_SalonID",
                table: "Booking",
                column: "SalonID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ShowID",
                table: "Booking",
                column: "ShowID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Salon_SalonID",
                table: "Booking",
                column: "SalonID",
                principalTable: "Salon",
                principalColumn: "SalonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Seat_SeatId",
                table: "Booking",
                column: "SeatId",
                principalTable: "Seat",
                principalColumn: "SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Show_ShowID",
                table: "Booking",
                column: "ShowID",
                principalTable: "Show",
                principalColumn: "ShowID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Salon_SalonID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Seat_SeatId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Show_ShowID",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_SalonID",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ShowID",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "SalonID",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "SeatId",
                table: "Booking",
                newName: "SeatID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_SeatId",
                table: "Booking",
                newName: "IX_Booking_SeatID");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Show",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RowId",
                table: "Salon",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShowID",
                table: "Booking",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShowID1",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Salon",
                keyColumn: "SalonID",
                keyValue: 1,
                column: "RowId",
                value: null);

            migrationBuilder.InsertData(
                table: "Show",
                columns: new[] { "ShowID", "MovieID", "MyProperty", "SalonID", "ShowDateTime" },
                values: new object[] { "S1", 1, 0, 1, new DateTime(2023, 11, 27, 11, 12, 17, 819, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ShowID1",
                table: "Booking",
                column: "ShowID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Seat_SeatID",
                table: "Booking",
                column: "SeatID",
                principalTable: "Seat",
                principalColumn: "SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Show_ShowID1",
                table: "Booking",
                column: "ShowID1",
                principalTable: "Show",
                principalColumn: "ShowID");
        }
    }
}
