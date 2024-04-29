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
				name: "Comments",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
					RestaurantId = table.Column<int>(type: "int", nullable: false),
					UserId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Comments", x => x.Id);
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
					RestaurantId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Menus", x => x.Id);
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
					Status = table.Column<bool>(type: "bit", nullable: false),
					CommentId = table.Column<int>(type: "int", nullable: false),
					CategoryId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Restaurants", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "UserOperationClaims",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					UserId = table.Column<int>(type: "int", nullable: false),
					OperationClaimId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
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
				name: "Products",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					UnitsInStock = table.Column<int>(type: "int", nullable: false),
					CategoryId = table.Column<int>(type: "int", nullable: false),
					RestaurantId = table.Column<int>(type: "int", nullable: false),
					MenuId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Products", x => x.Id);
					table.ForeignKey(
						name: "FK_Products_Menus_MenuId",
						column: x => x.MenuId,
						principalTable: "Menus",
						principalColumn: "Id");
				});

			migrationBuilder.CreateIndex(
				name: "IX_Products_MenuId",
				table: "Products",
				column: "MenuId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Categories");

			migrationBuilder.DropTable(
				name: "Comments");

			migrationBuilder.DropTable(
				name: "OperationClaims");

			migrationBuilder.DropTable(
				name: "Products");

			migrationBuilder.DropTable(
				name: "RestaurantOperationClaims");

			migrationBuilder.DropTable(
				name: "Restaurants");

			migrationBuilder.DropTable(
				name: "UserOperationClaims");

			migrationBuilder.DropTable(
				name: "Users");

			migrationBuilder.DropTable(
				name: "Menus");
		}
	}
}
