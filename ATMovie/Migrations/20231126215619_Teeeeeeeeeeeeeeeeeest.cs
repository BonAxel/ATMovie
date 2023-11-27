using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class Teeeeeeeeeeeeeeeeeest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Show",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowID",
                keyValue: "S1",
                columns: new[] { "MyProperty", "ShowDateTime" },
                values: new object[] { 0, new DateTime(2023, 11, 26, 22, 56, 19, 405, DateTimeKind.Local).AddTicks(8882) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Show");

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowID",
                keyValue: "S1",
                column: "ShowDateTime",
                value: new DateTime(2023, 11, 26, 14, 23, 28, 946, DateTimeKind.Local).AddTicks(1591));
        }
    }
}
