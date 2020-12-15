using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_productgroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product_Groups",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_Groups", x => x.GroupID);
                    table.ForeignKey(
                        name: "FK_product_Groups_product_Groups_ParentID",
                        column: x => x.ParentID,
                        principalTable: "product_Groups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_product_Groups_ParentID",
                table: "product_Groups",
                column: "ParentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product_Groups");
        }
    }
}
