using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class Hemmadator1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 1,
                column: "Runtime",
                value: "2h32m");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "Description", "Genre", "Price", "Runtime", "Title" },
                values: new object[] { 2, "A family in 1630s New England is torn apart by the forces of witchcraft, black magic and possession.", "Horror", 120, "1h32m", "The Witch" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 1,
                column: "Runtime",
                value: "120");
        }
    }
}
