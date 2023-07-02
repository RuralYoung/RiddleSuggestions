using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiddleSuggestions.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RiddleSuggestions",
                columns: table => new
                {
                    RiddleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    RiddleSuggestionRiddleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiddleSuggestions", x => x.RiddleID);
                    table.ForeignKey(
                        name: "FK_RiddleSuggestions_RiddleSuggestions_RiddleSuggestionRiddleID",
                        column: x => x.RiddleSuggestionRiddleID,
                        principalTable: "RiddleSuggestions",
                        principalColumn: "RiddleID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RiddleSuggestions_RiddleSuggestionRiddleID",
                table: "RiddleSuggestions",
                column: "RiddleSuggestionRiddleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiddleSuggestions");
        }
    }
}
