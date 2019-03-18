using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefsDishes.Migrations
{
    public partial class AddedChefID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Chef_CreatorChefId",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_CreatorChefId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "CreatorChefId",
                table: "Dish");

            migrationBuilder.AddColumn<int>(
                name: "ChefId",
                table: "Dish",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_ChefId",
                table: "Dish",
                column: "ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Chef_ChefId",
                table: "Dish",
                column: "ChefId",
                principalTable: "Chef",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Chef_ChefId",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_ChefId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "Dish");

            migrationBuilder.AddColumn<int>(
                name: "CreatorChefId",
                table: "Dish",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_CreatorChefId",
                table: "Dish",
                column: "CreatorChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Chef_CreatorChefId",
                table: "Dish",
                column: "CreatorChefId",
                principalTable: "Chef",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
