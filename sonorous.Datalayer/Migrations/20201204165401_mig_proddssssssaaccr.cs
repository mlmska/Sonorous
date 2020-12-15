using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_proddssssssaaccr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_GroupID",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "SubGroup",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubGroup",
                table: "Products",
                column: "SubGroup");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_product_Groups_SubGroup",
                table: "Products",
                column: "SubGroup",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_product_Groups_SubGroup",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SubGroup",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "SubGroup",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
