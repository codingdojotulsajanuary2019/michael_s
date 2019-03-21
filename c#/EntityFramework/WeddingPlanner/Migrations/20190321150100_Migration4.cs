using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Weddings_WeddingId1",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_WeddingId1",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "WeddingId1",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "WeddingId",
                table: "Weddings",
                nullable: false,
                oldClrType: typeof(long))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_WeddingId",
                table: "Reservations",
                column: "WeddingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Weddings_WeddingId",
                table: "Reservations",
                column: "WeddingId",
                principalTable: "Weddings",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Weddings_WeddingId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_WeddingId",
                table: "Reservations");

            migrationBuilder.AlterColumn<long>(
                name: "WeddingId",
                table: "Weddings",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<long>(
                name: "WeddingId1",
                table: "Reservations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_WeddingId1",
                table: "Reservations",
                column: "WeddingId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Weddings_WeddingId1",
                table: "Reservations",
                column: "WeddingId1",
                principalTable: "Weddings",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
