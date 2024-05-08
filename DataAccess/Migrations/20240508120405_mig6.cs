using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
	/// <inheritdoc />
	public partial class mig6 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_MenuImages_Menus_MenuId",
				table: "MenuImages");

			migrationBuilder.DropForeignKey(
				name: "FK_Menus_Restaurants_RestaurantId",
				table: "Menus");

			migrationBuilder.AlterColumn<int>(
				name: "RestaurantId",
				table: "Menus",
				type: "int",
				nullable: true,
				oldClrType: typeof(int),
				oldType: "int");

			migrationBuilder.AlterColumn<int>(
				name: "MenuId",
				table: "MenuImages",
				type: "int",
				nullable: true,
				oldClrType: typeof(int),
				oldType: "int");

			migrationBuilder.AddColumn<int>(
				name: "Menu",
				table: "MenuImages",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddForeignKey(
				name: "FK_MenuImages_Menus_MenuId",
				table: "MenuImages",
				column: "MenuId",
				principalTable: "Menus",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Menus_Restaurants_RestaurantId",
				table: "Menus",
				column: "RestaurantId",
				principalTable: "Restaurants",
				principalColumn: "Id");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_MenuImages_Menus_MenuId",
				table: "MenuImages");

			migrationBuilder.DropForeignKey(
				name: "FK_Menus_Restaurants_RestaurantId",
				table: "Menus");

			migrationBuilder.DropColumn(
				name: "Menu",
				table: "MenuImages");

			migrationBuilder.AlterColumn<int>(
				name: "RestaurantId",
				table: "Menus",
				type: "int",
				nullable: false,
				defaultValue: 0,
				oldClrType: typeof(int),
				oldType: "int",
				oldNullable: true);

			migrationBuilder.AlterColumn<int>(
				name: "MenuId",
				table: "MenuImages",
				type: "int",
				nullable: false,
				defaultValue: 0,
				oldClrType: typeof(int),
				oldType: "int",
				oldNullable: true);

			migrationBuilder.AddForeignKey(
				name: "FK_MenuImages_Menus_MenuId",
				table: "MenuImages",
				column: "MenuId",
				principalTable: "Menus",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Menus_Restaurants_RestaurantId",
				table: "Menus",
				column: "RestaurantId",
				principalTable: "Restaurants",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}
	}
}
