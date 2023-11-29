using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ATMovie.Migrations
{
    /// <inheritdoc />
    public partial class FirstPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "Description", "Genre", "Price", "Runtime", "Title" },
                values: new object[,]
                {
                    { 2, "Carol Danvers gets her powers entangled with those of Kamala Khan and Monica Rambeau, forcing them to work together to save the universe.", "Fantasy", 120, "1h45m", "The Marvels" },
                    { 3, "A dutiful damsel agrees to marry a handsome prince, only to find the royal family has recruited her as a sacrifice to repay an ancient debt. Thrown into a cave with a fire-breathing dragon, she must rely on her wits and will to survive.", "Fantasy", 120, "1h25m", "Damsel" },
                    { 4, "When a peaceful settlement on the edge of a distant moon finds itself threatened by the armies of a tyrannical ruling force, a mysterious stranger living among its villagers becomes their best hope for survival.", "Fantasy", 120, "2h13m", "Rebel Moon - Part One: A Child of Fire" },
                    { 5, "A charming thief and a band of unlikely adventurers embark on an epic quest to retrieve a lost relic, but things go dangerously awry when they run afoul of the wrong people.", "Fantasy", 120, "2h14m", "Dungeons & Dragions: Honor among Thieves" },
                    { 6, "Follow Riley, in her teenage years, encountering new emotions.", "Animation", 120, "2h14m", "Inside out 2" },
                    { 7, "Miles Morales catapults across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence. When the heroes clash on how to handle a new threat, Miles must redefine what it means to be a hero.", "Animation", 120, "2h20m", "Spider-Man: Across the Spider-Verse" },
                    { 8, "For the first time ever, Uta - the most beloved singer in the world - will reveal herself to the world at a live concert. The voice that the whole world has been waiting for is about to resound.", "Animation", 120, "1h55m", "One Piece: Red" },
                    { 9, "Garfield is about to go on a wild outdoor adventure. After an unexpected reunion with his long-lost father - the cat Vic - Garfield and Odie are forced to abandon their pampered life to join Vic in a hilarious, high-stakes heist.", "Animation", 120, "2h05m", "Katten Gustaf: Filmen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieID",
                keyValue: 9);
        }
    }
}
