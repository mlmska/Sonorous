using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_seeddatatprodcutstatsandlvl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductLevel",
                columns: new[] { "LevelID", "LevelTitle" },
                values: new object[,]
                {
                    { 1, "ساده" },
                    { 2, "متوسط" },
                    { 3, "پیشرفته" },
                    { 4, "خیلی پیشرفته" }
                });

            migrationBuilder.InsertData(
                table: "ProductStatus",
                columns: new[] { "StatusID", "StatusTilte" },
                values: new object[,]
                {
                    { 1, "موجود" },
                    { 2, "تمام شده" },
                    { 3, "در حال ساخت" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductLevel",
                keyColumn: "LevelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductLevel",
                keyColumn: "LevelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductLevel",
                keyColumn: "LevelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductLevel",
                keyColumn: "LevelID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductStatus",
                keyColumn: "StatusID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductStatus",
                keyColumn: "StatusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductStatus",
                keyColumn: "StatusID",
                keyValue: 3);
        }
    }
}
