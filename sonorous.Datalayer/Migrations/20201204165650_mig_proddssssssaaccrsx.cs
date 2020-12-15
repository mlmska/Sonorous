using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_proddssssssaaccrsx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_product_Groups_Product_GroupGroupID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Product_GroupGroupID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_GroupGroupID",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GroupID",
                table: "Products",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products",
                column: "GroupID",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_GroupID",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Product_GroupGroupID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Product_GroupGroupID",
                table: "Products",
                column: "Product_GroupGroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_product_Groups_Product_GroupGroupID",
                table: "Products",
                column: "Product_GroupGroupID",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
