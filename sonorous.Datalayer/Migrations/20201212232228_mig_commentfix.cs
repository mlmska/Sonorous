using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_commentfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "ProductComments",
                type: "nvarchar(700)",
                maxLength: 700,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(700)",
                oldMaxLength: 700,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "ProductComments",
                type: "nvarchar(700)",
                maxLength: 700,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(700)",
                oldMaxLength: 700);
        }
    }
}
