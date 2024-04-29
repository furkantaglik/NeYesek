using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
	/// <inheritdoc />
	public partial class mig2 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "CategoryId",
				table: "Restaurants");

			migrationBuilder.DropColumn(
				name: "CommentId",
				table: "Restaurants");

			migrationBuilder.AddColumn<int>(
				name: "CategoryId",
				table: "Categories",
				type: "int",
				nullable: true);

			migrationBuilder.AddColumn<int>(
				name: "RestaurantId",
				table: "Categories",
				type: "int",
				nullable: true);

			migrationBuilder.CreateIndex(
				name: "IX_Products_RestaurantId",
				table: "Products",
				column: "RestaurantId");

			migrationBuilder.CreateIndex(
				name: "IX_Menus_RestaurantId",
				table: "Menus",
				column: "RestaurantId");

			migrationBuilder.CreateIndex(
				name: "IX_Comments_RestaurantId",
				table: "Comments",
				column: "RestaurantId");

			migrationBuilder.CreateIndex(
				name: "IX_Comments_UserId",
				table: "Comments",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_Categories_CategoryId",
				table: "Categories",
				column: "CategoryId");

			migrationBuilder.CreateIndex(
				name: "IX_Categories_RestaurantId",
				table: "Categories",
				column: "RestaurantId");

			migrationBuilder.AddForeignKey(
				name: "FK_Categories_Categories_CategoryId",
				table: "Categories",
				column: "CategoryId",
				principalTable: "Categories",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Categories_Restaurants_RestaurantId",
				table: "Categories",
				column: "RestaurantId",
				principalTable: "Restaurants",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Comments_Restaurants_RestaurantId",
				table: "Comments",
				column: "RestaurantId",
				principalTable: "Restaurants",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Comments_Users_UserId",
				table: "Comments",
				column: "UserId",
				principalTable: "Users",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Menus_Restaurants_RestaurantId",
				table: "Menus",
				column: "RestaurantId",
				principalTable: "Restaurants",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Products_Restaurants_RestaurantId",
				table: "Products",
				column: "RestaurantId",
				principalTable: "Restaurants",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Categories_Categories_CategoryId",
				table: "Categories");

			migrationBuilder.DropForeignKey(
				name: "FK_Categories_Restaurants_RestaurantId",
				table: "Categories");

			migrationBuilder.DropForeignKey(
				name: "FK_Comments_Restaurants_RestaurantId",
				table: "Comments");

			migrationBuilder.DropForeignKey(
				name: "FK_Comments_Users_UserId",
				table: "Comments");

			migrationBuilder.DropForeignKey(
				name: "FK_Menus_Restaurants_RestaurantId",
				table: "Menus");

			migrationBuilder.DropForeignKey(
				name: "FK_Products_Restaurants_RestaurantId",
				table: "Products");

			migrationBuilder.DropIndex(
				name: "IX_Products_RestaurantId",
				table: "Products");

			migrationBuilder.DropIndex(
				name: "IX_Menus_RestaurantId",
				table: "Menus");

			migrationBuilder.DropIndex(
				name: "IX_Comments_RestaurantId",
				table: "Comments");

			migrationBuilder.DropIndex(
				name: "IX_Comments_UserId",
				table: "Comments");

			migrationBuilder.DropIndex(
				name: "IX_Categories_CategoryId",
				table: "Categories");

			migrationBuilder.DropIndex(
				name: "IX_Categories_RestaurantId",
				table: "Categories");

			migrationBuilder.DropColumn(
				name: "CategoryId",
				table: "Categories");

			migrationBuilder.DropColumn(
				name: "RestaurantId",
				table: "Categories");

			migrationBuilder.AddColumn<int>(
				name: "CategoryId",
				table: "Restaurants",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "CommentId",
				table: "Restaurants",
				type: "int",
				nullable: false,
				defaultValue: 0);
		}
	}
}
