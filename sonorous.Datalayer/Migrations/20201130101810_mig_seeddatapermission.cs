using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_seeddatapermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "ParentID", "PermissionTitle" },
                values: new object[] { 1, null, "مدیریت سایت" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "ParentID", "PermissionTitle" },
                values: new object[] { 2, 1, "مدیریت کاربران" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "ParentID", "PermissionTitle" },
                values: new object[] { 3, 2, "افزودن کاربر" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "ParentID", "PermissionTitle" },
                values: new object[] { 4, 2, "ویرایش کاربر" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "ParentID", "PermissionTitle" },
                values: new object[] { 5, 2, "حذف کاربر" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1);
        }
    }
}
