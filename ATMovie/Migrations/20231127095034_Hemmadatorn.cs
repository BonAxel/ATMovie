using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class Hemmadatorn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowID",
                keyValue: "S1",
                column: "ShowDateTime",
                value: new DateTime(2023, 11, 27, 10, 50, 34, 243, DateTimeKind.Local).AddTicks(7611));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowID",
                keyValue: "S1",
                column: "ShowDateTime",
                value: new DateTime(2023, 11, 26, 22, 56, 19, 405, DateTimeKind.Local).AddTicks(8882));
        }
    }
}
