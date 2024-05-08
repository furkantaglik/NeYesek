using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
	/// <inheritdoc />
	public partial class mig4 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "CategoryImages",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
					CategoryId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_CategoryImages", x => x.Id);
					table.ForeignKey(
						name: "FK_CategoryImages_Categories_CategoryId",
						column: x => x.CategoryId,
						principalTable: "Categories",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "MenuImages",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
					MenuId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_MenuImages", x => x.Id);
					table.ForeignKey(
						name: "FK_MenuImages_Menus_MenuId",
						column: x => x.MenuId,
						principalTable: "Menus",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "ProductImages",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ProductId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_ProductImages", x => x.Id);
					table.ForeignKey(
						name: "FK_ProductImages_Products_ProductId",
						column: x => x.ProductId,
						principalTable: "Products",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "RestaurantImages",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
					RestaurantId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_RestaurantImages", x => x.Id);
					table.ForeignKey(
						name: "FK_RestaurantImages_Restaurants_RestaurantId",
						column: x => x.RestaurantId,
						principalTable: "Restaurants",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_CategoryImages_CategoryId",
				table: "CategoryImages",
				column: "CategoryId");

			migrationBuilder.CreateIndex(
				name: "IX_MenuImages_MenuId",
				table: "MenuImages",
				column: "MenuId");

			migrationBuilder.CreateIndex(
				name: "IX_ProductImages_ProductId",
				table: "ProductImages",
				column: "ProductId");

			migrationBuilder.CreateIndex(
				name: "IX_RestaurantImages_RestaurantId",
				table: "RestaurantImages",
				column: "RestaurantId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "CategoryImages");

			migrationBuilder.DropTable(
				name: "MenuImages");

			migrationBuilder.DropTable(
				name: "ProductImages");

			migrationBuilder.DropTable(
				name: "RestaurantImages");
		}
	}
}
