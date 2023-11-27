using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salon",
                columns: table => new
                {
                    SalonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfChairs = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salon", x => x.SalonID);
                });

            migrationBuilder.CreateTable(
                name: "Row",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    SalonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Row", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_Row_Salon_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salon",
                        principalColumn: "SalonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Show",
                columns: table => new
                {
                    ShowID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShowDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieID = table.Column<int>(type: "int", nullable: true),
                    SalonID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Show", x => x.ShowID);
                    table.ForeignKey(
                        name: "FK_Show_Movie_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movie",
                        principalColumn: "MovieID");
                    table.ForeignKey(
                        name: "FK_Show_Salon_SalonID",
                        column: x => x.SalonID,
                        principalTable: "Salon",
                        principalColumn: "SalonID");
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false),
                    SalonId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_Seat_Row_RowId",
                        column: x => x.RowId,
                        principalTable: "Row",
                        principalColumn: "RowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Salon",
                columns: new[] { "SalonID", "NumberOfChairs", "RowId", "SalonName" },
                values: new object[] { 1, 300, null, "Tobias Hembio" });

            migrationBuilder.InsertData(
                table: "Row",
                columns: new[] { "RowId", "RowNumber", "SalonId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Show",
                columns: new[] { "ShowID", "MovieID", "SalonID", "ShowDateTime" },
                values: new object[] { "S1", 1, 1, new DateTime(2023, 11, 26, 14, 23, 28, 946, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.CreateIndex(
                name: "IX_Row_SalonId",
                table: "Row",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_RowId",
                table: "Seat",
                column: "RowId");

            migrationBuilder.CreateIndex(
                name: "IX_Show_MovieID",
                table: "Show",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Show_SalonID",
                table: "Show",
                column: "SalonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Show");

            migrationBuilder.DropTable(
                name: "Row");

            migrationBuilder.DropTable(
                name: "Salon");
        }
    }
}
