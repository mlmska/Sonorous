using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductLevel",
                columns: table => new
                {
                    LevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLevel", x => x.LevelID);
                });

            migrationBuilder.CreateTable(
                name: "ProductStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusTilte = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    SubGroup = table.Column<int>(type: "int", nullable: true),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true),
                    ProductImageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Product_GroupGroupID = table.Column<int>(type: "int", nullable: true),
                    ProductStatusStatusID = table.Column<int>(type: "int", nullable: true),
                    ProductLevelLevelID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_product_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "product_Groups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_product_Groups_Product_GroupGroupID",
                        column: x => x.Product_GroupGroupID,
                        principalTable: "product_Groups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductLevel_ProductLevelLevelID",
                        column: x => x.ProductLevelLevelID,
                        principalTable: "ProductLevel",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductStatus_ProductStatusStatusID",
                        column: x => x.ProductStatusStatusID,
                        principalTable: "ProductStatus",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Users_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_GroupID",
                table: "Product",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Product_GroupGroupID",
                table: "Product",
                column: "Product_GroupGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductLevelLevelID",
                table: "Product",
                column: "ProductLevelLevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductStatusStatusID",
                table: "Product",
                column: "ProductStatusStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_TeacherID",
                table: "Product",
                column: "TeacherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductLevel");

            migrationBuilder.DropTable(
                name: "ProductStatus");
        }
    }
}
