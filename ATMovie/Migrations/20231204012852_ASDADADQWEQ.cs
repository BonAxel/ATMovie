using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class ASDADADQWEQ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JunctionId",
                table: "Junctions",
                newName: "RowSeatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RowSeatId",
                table: "Junctions",
                newName: "JunctionId");
        }
    }
}
