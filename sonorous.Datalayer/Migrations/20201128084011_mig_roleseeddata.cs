using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_roleseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Roletitle" },
                values: new object[] { 1, "مدیر سایت" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Roletitle" },
                values: new object[] { 2, "ادمین" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Roletitle" },
                values: new object[] { 3, "کاربر عادی" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3);
        }
    }
}
