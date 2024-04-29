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
			migrationBuilder.DropForeignKey(
				name: "FK_Categories_Categories_CategoryId",
				table: "Categories");

			migrationBuilder.DropForeignKey(
				name: "FK_Categories_Restaurants_RestaurantId",
				table: "Categories");

			migrationBuilder.DropForeignKey(
				name: "FK_Products_Categories_CategoryId",
				table: "Products");

			migrationBuilder.DropIndex(
				name: "IX_Products_CategoryId",
				table: "Products");

			migrationBuilder.DropIndex(
				name: "IX_Categories_CategoryId",
				table: "Categories");

			migrationBuilder.DropIndex(
				name: "IX_Categories_RestaurantId",
				table: "Categories");

			migrationBuilder.DropColumn(
				name: "CategoryId",
				table: "Products");

			migrationBuilder.DropColumn(
				name: "CategoryId",
				table: "Categories");

			migrationBuilder.DropColumn(
				name: "RestaurantId",
				table: "Categories");

			migrationBuilder.RenameColumn(
				name: "UserId",
				table: "UserOperationClaims",
				newName: "userId");

			migrationBuilder.CreateTable(
				name: "CategoryProduct",
				columns: table => new
				{
					CategoriesId = table.Column<int>(type: "int", nullable: false),
					ProductsId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
					table.ForeignKey(
						name: "FK_CategoryProduct_Categories_CategoriesId",
						column: x => x.CategoriesId,
						principalTable: "Categories",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_CategoryProduct_Products_ProductsId",
						column: x => x.ProductsId,
						principalTable: "Products",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "CategoryRestaurant",
				columns: table => new
				{
					CategoriesId = table.Column<int>(type: "int", nullable: false),
					RestaurantsId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_CategoryRestaurant", x => new { x.CategoriesId, x.RestaurantsId });
					table.ForeignKey(
						name: "FK_CategoryRestaurant_Categories_CategoriesId",
						column: x => x.CategoriesId,
						principalTable: "Categories",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_CategoryRestaurant_Restaurants_RestaurantsId",
						column: x => x.RestaurantsId,
						principalTable: "Restaurants",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_UserOperationClaims_OperationClaimId",
				table: "UserOperationClaims",
				column: "OperationClaimId");

			migrationBuilder.CreateIndex(
				name: "IX_UserOperationClaims_userId",
				table: "UserOperationClaims",
				column: "userId");

			migrationBuilder.CreateIndex(
				name: "IX_RestaurantOperationClaims_OperationClaimId",
				table: "RestaurantOperationClaims",
				column: "OperationClaimId");

			migrationBuilder.CreateIndex(
				name: "IX_RestaurantOperationClaims_RestaurantId",
				table: "RestaurantOperationClaims",
				column: "RestaurantId");

			migrationBuilder.CreateIndex(
				name: "IX_CategoryProduct_ProductsId",
				table: "CategoryProduct",
				column: "ProductsId");

			migrationBuilder.CreateIndex(
				name: "IX_CategoryRestaurant_RestaurantsId",
				table: "CategoryRestaurant",
				column: "RestaurantsId");

			migrationBuilder.AddForeignKey(
				name: "FK_RestaurantOperationClaims_OperationClaims_OperationClaimId",
				table: "RestaurantOperationClaims",
				column: "OperationClaimId",
				principalTable: "OperationClaims",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_RestaurantOperationClaims_Restaurants_RestaurantId",
				table: "RestaurantOperationClaims",
				column: "RestaurantId",
				principalTable: "Restaurants",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
				table: "UserOperationClaims",
				column: "OperationClaimId",
				principalTable: "OperationClaims",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_UserOperationClaims_Users_userId",
				table: "UserOperationClaims",
				column: "userId",
				principalTable: "Users",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_RestaurantOperationClaims_OperationClaims_OperationClaimId",
				table: "RestaurantOperationClaims");

			migrationBuilder.DropForeignKey(
				name: "FK_RestaurantOperationClaims_Restaurants_RestaurantId",
				table: "RestaurantOperationClaims");

			migrationBuilder.DropForeignKey(
				name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
				table: "UserOperationClaims");

			migrationBuilder.DropForeignKey(
				name: "FK_UserOperationClaims_Users_userId",
				table: "UserOperationClaims");

			migrationBuilder.DropTable(
				name: "CategoryProduct");

			migrationBuilder.DropTable(
				name: "CategoryRestaurant");

			migrationBuilder.DropIndex(
				name: "IX_UserOperationClaims_OperationClaimId",
				table: "UserOperationClaims");

			migrationBuilder.DropIndex(
				name: "IX_UserOperationClaims_userId",
				table: "UserOperationClaims");

			migrationBuilder.DropIndex(
				name: "IX_RestaurantOperationClaims_OperationClaimId",
				table: "RestaurantOperationClaims");

			migrationBuilder.DropIndex(
				name: "IX_RestaurantOperationClaims_RestaurantId",
				table: "RestaurantOperationClaims");

			migrationBuilder.RenameColumn(
				name: "userId",
				table: "UserOperationClaims",
				newName: "UserId");

			migrationBuilder.AddColumn<int>(
				name: "CategoryId",
				table: "Products",
				type: "int",
				nullable: false,
				defaultValue: 0);

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
				name: "IX_Products_CategoryId",
				table: "Products",
				column: "CategoryId");

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
				name: "FK_Products_Categories_CategoryId",
				table: "Products",
				column: "CategoryId",
				principalTable: "Categories",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}
	}
}
