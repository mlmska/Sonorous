using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_proddssssssaacc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_product_Groups_GroupID",
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

            migrationBuilder.AlterColumn<int>(
                name: "GroupID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "SubGroup",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GroupID",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products",
                column: "GroupID",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
