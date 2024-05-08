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
			migrationBuilder.DropForeignKey(
				name: "FK_MenuProduct_Menus_MenuId",
				table: "MenuProduct");

			migrationBuilder.RenameColumn(
				name: "MenuId",
				table: "MenuProduct",
				newName: "MenusId");

			migrationBuilder.AddForeignKey(
				name: "FK_MenuProduct_Menus_MenusId",
				table: "MenuProduct",
				column: "MenusId",
				principalTable: "Menus",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_MenuProduct_Menus_MenusId",
				table: "MenuProduct");

			migrationBuilder.RenameColumn(
				name: "MenusId",
				table: "MenuProduct",
				newName: "MenuId");

			migrationBuilder.AddForeignKey(
				name: "FK_MenuProduct_Menus_MenuId",
				table: "MenuProduct",
				column: "MenuId",
				principalTable: "Menus",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}
	}
}
