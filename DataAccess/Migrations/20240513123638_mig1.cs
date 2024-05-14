using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
	/// <inheritdoc />
	public partial class mig1 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Categories",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Categories", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "OperationClaims",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_OperationClaims", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Restaurants",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
					TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
					PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
					PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Restaurants", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Users",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
					TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
					PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
					PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Users", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "CategoryImages",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
					CategoryId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_CategoryImages", x => x.Id);
					table.ForeignKey(
						name: "FK_CategoryImages_Categories_CategoryId",
						column: x => x.CategoryId,
						principalTable: "Categories",
						principalColumn: "Id");
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

			migrationBuilder.CreateTable(
				name: "Menus",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					RestaurantId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Menus", x => x.Id);
					table.ForeignKey(
						name: "FK_Menus_Restaurants_RestaurantId",
						column: x => x.RestaurantId,
						principalTable: "Restaurants",
						principalColumn: "Id");
				});

			migrationBuilder.CreateTable(
				name: "Products",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					UnitsInStock = table.Column<int>(type: "int", nullable: false),
					RestaurantId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Products", x => x.Id);
					table.ForeignKey(
						name: "FK_Products_Restaurants_RestaurantId",
						column: x => x.RestaurantId,
						principalTable: "Restaurants",
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
					RestaurantId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_RestaurantImages", x => x.Id);
					table.ForeignKey(
						name: "FK_RestaurantImages_Restaurants_RestaurantId",
						column: x => x.RestaurantId,
						principalTable: "Restaurants",
						principalColumn: "Id");
				});

			migrationBuilder.CreateTable(
				name: "RestaurantOperationClaims",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					RestaurantId = table.Column<int>(type: "int", nullable: false),
					OperationClaimId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_RestaurantOperationClaims", x => x.Id);
					table.ForeignKey(
						name: "FK_RestaurantOperationClaims_OperationClaims_OperationClaimId",
						column: x => x.OperationClaimId,
						principalTable: "OperationClaims",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_RestaurantOperationClaims_Restaurants_RestaurantId",
						column: x => x.RestaurantId,
						principalTable: "Restaurants",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "UserOperationClaims",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					userId = table.Column<int>(type: "int", nullable: false),
					OperationClaimId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
					table.ForeignKey(
						name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
						column: x => x.OperationClaimId,
						principalTable: "OperationClaims",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_UserOperationClaims_Users_userId",
						column: x => x.userId,
						principalTable: "Users",
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
					MenuId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_MenuImages", x => x.Id);
					table.ForeignKey(
						name: "FK_MenuImages_Menus_MenuId",
						column: x => x.MenuId,
						principalTable: "Menus",
						principalColumn: "Id");
				});

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
				name: "Comments",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
					RestaurantId = table.Column<int>(type: "int", nullable: true),
					ProductId = table.Column<int>(type: "int", nullable: true),
					UserId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Comments", x => x.Id);
					table.ForeignKey(
						name: "FK_Comments_Products_ProductId",
						column: x => x.ProductId,
						principalTable: "Products",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_Comments_Restaurants_RestaurantId",
						column: x => x.RestaurantId,
						principalTable: "Restaurants",
						principalColumn: "Id");
					table.ForeignKey(
						name: "FK_Comments_Users_UserId",
						column: x => x.UserId,
						principalTable: "Users",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "MenuProduct",
				columns: table => new
				{
					MenusId = table.Column<int>(type: "int", nullable: false),
					ProductsId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_MenuProduct", x => new { x.MenusId, x.ProductsId });
					table.ForeignKey(
						name: "FK_MenuProduct_Menus_MenusId",
						column: x => x.MenusId,
						principalTable: "Menus",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_MenuProduct_Products_ProductsId",
						column: x => x.ProductsId,
						principalTable: "Products",
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
					ProductId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_ProductImages", x => x.Id);
					table.ForeignKey(
						name: "FK_ProductImages_Products_ProductId",
						column: x => x.ProductId,
						principalTable: "Products",
						principalColumn: "Id");
				});

			migrationBuilder.CreateTable(
				name: "ProductMenu",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					MenuId = table.Column<int>(type: "int", nullable: false),
					ProductId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_ProductMenu", x => x.Id);
					table.ForeignKey(
						name: "FK_ProductMenu_Menus_MenuId",
						column: x => x.MenuId,
						principalTable: "Menus",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_ProductMenu_Products_ProductId",
						column: x => x.ProductId,
						principalTable: "Products",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_CategoryImages_CategoryId",
				table: "CategoryImages",
				column: "CategoryId",
				unique: true,
				filter: "[CategoryId] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_CategoryProduct_ProductsId",
				table: "CategoryProduct",
				column: "ProductsId");

			migrationBuilder.CreateIndex(
				name: "IX_CategoryRestaurant_RestaurantsId",
				table: "CategoryRestaurant",
				column: "RestaurantsId");

			migrationBuilder.CreateIndex(
				name: "IX_Comments_ProductId",
				table: "Comments",
				column: "ProductId");

			migrationBuilder.CreateIndex(
				name: "IX_Comments_RestaurantId",
				table: "Comments",
				column: "RestaurantId");

			migrationBuilder.CreateIndex(
				name: "IX_Comments_UserId",
				table: "Comments",
				column: "UserId");

			migrationBuilder.CreateIndex(
				name: "IX_MenuImages_MenuId",
				table: "MenuImages",
				column: "MenuId",
				unique: true,
				filter: "[MenuId] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_MenuProduct_ProductsId",
				table: "MenuProduct",
				column: "ProductsId");

			migrationBuilder.CreateIndex(
				name: "IX_Menus_RestaurantId",
				table: "Menus",
				column: "RestaurantId");

			migrationBuilder.CreateIndex(
				name: "IX_ProductImages_ProductId",
				table: "ProductImages",
				column: "ProductId",
				unique: true,
				filter: "[ProductId] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_ProductMenu_MenuId",
				table: "ProductMenu",
				column: "MenuId");

			migrationBuilder.CreateIndex(
				name: "IX_ProductMenu_ProductId",
				table: "ProductMenu",
				column: "ProductId");

			migrationBuilder.CreateIndex(
				name: "IX_Products_RestaurantId",
				table: "Products",
				column: "RestaurantId");

			migrationBuilder.CreateIndex(
				name: "IX_RestaurantImages_RestaurantId",
				table: "RestaurantImages",
				column: "RestaurantId",
				unique: true,
				filter: "[RestaurantId] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_RestaurantOperationClaims_OperationClaimId",
				table: "RestaurantOperationClaims",
				column: "OperationClaimId");

			migrationBuilder.CreateIndex(
				name: "IX_RestaurantOperationClaims_RestaurantId",
				table: "RestaurantOperationClaims",
				column: "RestaurantId");

			migrationBuilder.CreateIndex(
				name: "IX_UserOperationClaims_OperationClaimId",
				table: "UserOperationClaims",
				column: "OperationClaimId");

			migrationBuilder.CreateIndex(
				name: "IX_UserOperationClaims_userId",
				table: "UserOperationClaims",
				column: "userId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "CategoryImages");

			migrationBuilder.DropTable(
				name: "CategoryProduct");

			migrationBuilder.DropTable(
				name: "CategoryRestaurant");

			migrationBuilder.DropTable(
				name: "Comments");

			migrationBuilder.DropTable(
				name: "MenuImages");

			migrationBuilder.DropTable(
				name: "MenuProduct");

			migrationBuilder.DropTable(
				name: "ProductImages");

			migrationBuilder.DropTable(
				name: "ProductMenu");

			migrationBuilder.DropTable(
				name: "RestaurantImages");

			migrationBuilder.DropTable(
				name: "RestaurantOperationClaims");

			migrationBuilder.DropTable(
				name: "UserOperationClaims");

			migrationBuilder.DropTable(
				name: "Categories");

			migrationBuilder.DropTable(
				name: "Menus");

			migrationBuilder.DropTable(
				name: "Products");

			migrationBuilder.DropTable(
				name: "OperationClaims");

			migrationBuilder.DropTable(
				name: "Users");

			migrationBuilder.DropTable(
				name: "Restaurants");
		}
	}
}
