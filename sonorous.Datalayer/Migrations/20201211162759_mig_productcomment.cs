using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_productcomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductComments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
                    isAdminRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_ProductComments_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductComments_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_ProductID",
                table: "ProductComments",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_UserID",
                table: "ProductComments",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductComments");
        }
    }
}
