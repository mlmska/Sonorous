using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_userdiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDiscountCodes",
                columns: table => new
                {
                    US_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DiscountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDiscountCodes", x => x.US_ID);
                    table.ForeignKey(
                        name: "FK_UserDiscountCodes_Discounts_DiscountID",
                        column: x => x.DiscountID,
                        principalTable: "Discounts",
                        principalColumn: "DiscountID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserDiscountCodes_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscountCodes_DiscountID",
                table: "UserDiscountCodes",
                column: "DiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscountCodes_UserID",
                table: "UserDiscountCodes",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDiscountCodes");
        }
    }
}
