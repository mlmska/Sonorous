using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_fixwallet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Walletts_WallettTypes_WallettTypeTypeID",
                table: "Walletts");

            migrationBuilder.DropIndex(
                name: "IX_Walletts_WallettTypeTypeID",
                table: "Walletts");

            migrationBuilder.DropColumn(
                name: "WallettTypeTypeID",
                table: "Walletts");

            migrationBuilder.CreateIndex(
                name: "IX_Walletts_TypeID",
                table: "Walletts",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Walletts_WallettTypes_TypeID",
                table: "Walletts",
                column: "TypeID",
                principalTable: "WallettTypes",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Walletts_WallettTypes_TypeID",
                table: "Walletts");

            migrationBuilder.DropIndex(
                name: "IX_Walletts_TypeID",
                table: "Walletts");

            migrationBuilder.AddColumn<int>(
                name: "WallettTypeTypeID",
                table: "Walletts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Walletts_WallettTypeTypeID",
                table: "Walletts",
                column: "WallettTypeTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Walletts_WallettTypes_WallettTypeTypeID",
                table: "Walletts",
                column: "WallettTypeTypeID",
                principalTable: "WallettTypes",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
