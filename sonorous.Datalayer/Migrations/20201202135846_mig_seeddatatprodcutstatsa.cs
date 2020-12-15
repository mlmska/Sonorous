using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_seeddatatprodcutstatsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_product_Groups_GroupID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_product_Groups_Product_GroupGroupID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductLevel_ProductLevelLevelID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductStatus_ProductStatusStatusID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Users_TeacherID",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductStatus",
                table: "ProductStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLevel",
                table: "ProductLevel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "ProductStatus",
                newName: "ProductStatuses");

            migrationBuilder.RenameTable(
                name: "ProductLevel",
                newName: "ProductLevels");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Product_TeacherID",
                table: "Products",
                newName: "IX_Products_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductStatusStatusID",
                table: "Products",
                newName: "IX_Products_ProductStatusStatusID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductLevelLevelID",
                table: "Products",
                newName: "IX_Products_ProductLevelLevelID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Product_GroupGroupID",
                table: "Products",
                newName: "IX_Products_Product_GroupGroupID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_GroupID",
                table: "Products",
                newName: "IX_Products_GroupID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductStatuses",
                table: "ProductStatuses",
                column: "StatusID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLevels",
                table: "ProductLevels",
                column: "LevelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products",
                column: "GroupID",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_product_Groups_Product_GroupGroupID",
                table: "Products",
                column: "Product_GroupGroupID",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLevels_ProductLevelLevelID",
                table: "Products",
                column: "ProductLevelLevelID",
                principalTable: "ProductLevels",
                principalColumn: "LevelID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductStatuses_ProductStatusStatusID",
                table: "Products",
                column: "ProductStatusStatusID",
                principalTable: "ProductStatuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_TeacherID",
                table: "Products",
                column: "TeacherID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_product_Groups_Product_GroupGroupID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLevels_ProductLevelLevelID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductStatuses_ProductStatusStatusID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_TeacherID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductStatuses",
                table: "ProductStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLevels",
                table: "ProductLevels");

            migrationBuilder.RenameTable(
                name: "ProductStatuses",
                newName: "ProductStatus");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "ProductLevels",
                newName: "ProductLevel");

            migrationBuilder.RenameIndex(
                name: "IX_Products_TeacherID",
                table: "Product",
                newName: "IX_Product_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductStatusStatusID",
                table: "Product",
                newName: "IX_Product_ProductStatusStatusID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductLevelLevelID",
                table: "Product",
                newName: "IX_Product_ProductLevelLevelID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Product_GroupGroupID",
                table: "Product",
                newName: "IX_Product_Product_GroupGroupID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_GroupID",
                table: "Product",
                newName: "IX_Product_GroupID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductStatus",
                table: "ProductStatus",
                column: "StatusID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLevel",
                table: "ProductLevel",
                column: "LevelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_product_Groups_GroupID",
                table: "Product",
                column: "GroupID",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_product_Groups_Product_GroupGroupID",
                table: "Product",
                column: "Product_GroupGroupID",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductLevel_ProductLevelLevelID",
                table: "Product",
                column: "ProductLevelLevelID",
                principalTable: "ProductLevel",
                principalColumn: "LevelID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductStatus_ProductStatusStatusID",
                table: "Product",
                column: "ProductStatusStatusID",
                principalTable: "ProductStatus",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Users_TeacherID",
                table: "Product",
                column: "TeacherID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
