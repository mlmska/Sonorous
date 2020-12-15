using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sonorous.Datalayer.Migrations
{
    public partial class mig_Ordersd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLevels_LevelID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductStatuses_StatusID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_TeacherID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionID",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Roles_RoleID",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleID",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserID",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Walletts_Users_UserID",
                table: "Walletts");

            migrationBuilder.DropForeignKey(
                name: "FK_Walletts_WallettTypes_TypeID",
                table: "Walletts");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    OrderSum = table.Column<int>(type: "int", nullable: false),
                    isFinaly = table.Column<bool>(type: "bit", nullable: false),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.DetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products",
                column: "GroupID",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLevels_LevelID",
                table: "Products",
                column: "LevelID",
                principalTable: "ProductLevels",
                principalColumn: "LevelID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductStatuses_StatusID",
                table: "Products",
                column: "StatusID",
                principalTable: "ProductStatuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_TeacherID",
                table: "Products",
                column: "TeacherID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionID",
                table: "RolePermissions",
                column: "PermissionID",
                principalTable: "Permissions",
                principalColumn: "PermissionID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Roles_RoleID",
                table: "RolePermissions",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleID",
                table: "UserRoles",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserID",
                table: "UserRoles",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Walletts_Users_UserID",
                table: "Walletts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Walletts_WallettTypes_TypeID",
                table: "Walletts",
                column: "TypeID",
                principalTable: "WallettTypes",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductLevels_LevelID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductStatuses_StatusID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_TeacherID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionID",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Roles_RoleID",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleID",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserID",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Walletts_Users_UserID",
                table: "Walletts");

            migrationBuilder.DropForeignKey(
                name: "FK_Walletts_WallettTypes_TypeID",
                table: "Walletts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_product_Groups_GroupID",
                table: "Products",
                column: "GroupID",
                principalTable: "product_Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductLevels_LevelID",
                table: "Products",
                column: "LevelID",
                principalTable: "ProductLevels",
                principalColumn: "LevelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductStatuses_StatusID",
                table: "Products",
                column: "StatusID",
                principalTable: "ProductStatuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_TeacherID",
                table: "Products",
                column: "TeacherID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionID",
                table: "RolePermissions",
                column: "PermissionID",
                principalTable: "Permissions",
                principalColumn: "PermissionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Roles_RoleID",
                table: "RolePermissions",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleID",
                table: "UserRoles",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserID",
                table: "UserRoles",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Walletts_Users_UserID",
                table: "Walletts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Walletts_WallettTypes_TypeID",
                table: "Walletts",
                column: "TypeID",
                principalTable: "WallettTypes",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
