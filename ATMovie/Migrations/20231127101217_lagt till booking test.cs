using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class lagttillbookingtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kundnamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Epost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowID = table.Column<int>(type: "int", nullable: true),
                    ShowID1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SeatID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Booking_Seat_SeatID",
                        column: x => x.SeatID,
                        principalTable: "Seat",
                        principalColumn: "SeatId");
                    table.ForeignKey(
                        name: "FK_Booking_Show_ShowID1",
                        column: x => x.ShowID1,
                        principalTable: "Show",
                        principalColumn: "ShowID");
                });

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowID",
                keyValue: "S1",
                column: "ShowDateTime",
                value: new DateTime(2023, 11, 27, 11, 12, 17, 819, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.CreateIndex(
                name: "IX_Booking_SeatID",
                table: "Booking",
                column: "SeatID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ShowID1",
                table: "Booking",
                column: "ShowID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowID",
                keyValue: "S1",
                column: "ShowDateTime",
                value: new DateTime(2023, 11, 27, 10, 50, 34, 243, DateTimeKind.Local).AddTicks(7611));
        }
    }
}
