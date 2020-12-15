using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_seeddatapermissinsecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "ParentID", "PermissionTitle" },
                values: new object[] { 6, 1, "مدیریت نقش ها" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "ParentID", "PermissionTitle" },
                values: new object[] { 7, 6, "افزودن نقش" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "ParentID", "PermissionTitle" },
                values: new object[] { 8, 6, "ویرایش نقش" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "ParentID", "PermissionTitle" },
                values: new object[] { 9, 6, "حذف نقش" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6);
        }
    }
}
