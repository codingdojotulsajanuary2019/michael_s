using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_GuestId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "GuestId",
                table: "Reservations",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_GuestId",
                table: "Reservations",
                newName: "IX_Reservations_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reservations",
                newName: "GuestId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                newName: "IX_Reservations_GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_GuestId",
                table: "Reservations",
                column: "GuestId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
