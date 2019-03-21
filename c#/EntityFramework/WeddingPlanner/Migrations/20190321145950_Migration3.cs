using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Users_GuestId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Wedding_WeddingId1",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Wedding_Users_UserId",
                table: "Wedding");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wedding",
                table: "Wedding");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.RenameTable(
                name: "Wedding",
                newName: "Weddings");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameIndex(
                name: "IX_Wedding_UserId",
                table: "Weddings",
                newName: "IX_Weddings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_WeddingId1",
                table: "Reservations",
                newName: "IX_Reservations_WeddingId1");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_GuestId",
                table: "Reservations",
                newName: "IX_Reservations_GuestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weddings",
                table: "Weddings",
                column: "WeddingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_GuestId",
                table: "Reservations",
                column: "GuestId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Weddings_WeddingId1",
                table: "Reservations",
                column: "WeddingId1",
                principalTable: "Weddings",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weddings_Users_UserId",
                table: "Weddings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_GuestId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Weddings_WeddingId1",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Weddings_Users_UserId",
                table: "Weddings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weddings",
                table: "Weddings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.RenameTable(
                name: "Weddings",
                newName: "Wedding");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameIndex(
                name: "IX_Weddings_UserId",
                table: "Wedding",
                newName: "IX_Wedding_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_WeddingId1",
                table: "Reservation",
                newName: "IX_Reservation_WeddingId1");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_GuestId",
                table: "Reservation",
                newName: "IX_Reservation_GuestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wedding",
                table: "Wedding",
                column: "WeddingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Users_GuestId",
                table: "Reservation",
                column: "GuestId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Wedding_WeddingId1",
                table: "Reservation",
                column: "WeddingId1",
                principalTable: "Wedding",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wedding_Users_UserId",
                table: "Wedding",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
