using Microsoft.EntityFrameworkCore.Migrations;

namespace BrightIdeas.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrightIdea_Users_UserId",
                table: "BrightIdea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrightIdea",
                table: "BrightIdea");

            migrationBuilder.RenameTable(
                name: "BrightIdea",
                newName: "BrightIdeas");

            migrationBuilder.RenameIndex(
                name: "IX_BrightIdea_UserId",
                table: "BrightIdeas",
                newName: "IX_BrightIdeas_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrightIdeas",
                table: "BrightIdeas",
                column: "IdeaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrightIdeas_Users_UserId",
                table: "BrightIdeas",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrightIdeas_Users_UserId",
                table: "BrightIdeas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrightIdeas",
                table: "BrightIdeas");

            migrationBuilder.RenameTable(
                name: "BrightIdeas",
                newName: "BrightIdea");

            migrationBuilder.RenameIndex(
                name: "IX_BrightIdeas_UserId",
                table: "BrightIdea",
                newName: "IX_BrightIdea_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrightIdea",
                table: "BrightIdea",
                column: "IdeaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrightIdea_Users_UserId",
                table: "BrightIdea",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
