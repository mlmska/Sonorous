using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_proddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLevels_ProductLevelLevelID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductStatuses_ProductStatusStatusID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductLevelLevelID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductStatusStatusID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductLevelLevelID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductStatusStatusID",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LevelID",
                table: "Products",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StatusID",
                table: "Products",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLevels_LevelID",
                table: "Products",
                column: "LevelID",
                principalTable: "ProductLevels",
                principalColumn: "LevelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductStatuses_StatusID",
                table: "Products",
                column: "StatusID",
                principalTable: "ProductStatuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLevels_LevelID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductStatuses_StatusID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_LevelID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_StatusID",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductLevelLevelID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductStatusStatusID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductLevelLevelID",
                table: "Products",
                column: "ProductLevelLevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductStatusStatusID",
                table: "Products",
                column: "ProductStatusStatusID");

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
        }
    }
}
