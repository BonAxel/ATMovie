using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class TEEEEEEEEEEEEEEST : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Row_RowId",
                table: "Seat");

            migrationBuilder.AlterColumn<int>(
                name: "RowId",
                table: "Seat",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Row_RowId",
                table: "Seat",
                column: "RowId",
                principalTable: "Row",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Row_RowId",
                table: "Seat");

            migrationBuilder.AlterColumn<int>(
                name: "RowId",
                table: "Seat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Row_RowId",
                table: "Seat",
                column: "RowId",
                principalTable: "Row",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
