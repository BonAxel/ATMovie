using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class DATABASETEST : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Row",
                keyColumn: "RowId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salon",
                keyColumn: "SalonID",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ShowID",
                table: "Show",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ShowID",
                table: "Booking",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShowID",
                table: "Show",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ShowID",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "Description", "Genre", "Price", "Runtime", "Title" },
                values: new object[,]
                {
                    { 1, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "Fantasy", 120, "2h32m", "Lord of the Rings" },
                    { 2, "A family in 1630s New England is torn apart by the forces of witchcraft, black magic and possession.", "Horror", 120, "1h32m", "The Witch" }
                });

            migrationBuilder.InsertData(
                table: "Salon",
                columns: new[] { "SalonID", "NumberOfChairs", "SalonName" },
                values: new object[] { 1, 300, "Tobias Hembio" });

            migrationBuilder.InsertData(
                table: "Row",
                columns: new[] { "RowId", "RowNumber", "SalonId" },
                values: new object[] { 1, 1, 1 });
        }
    }
}
