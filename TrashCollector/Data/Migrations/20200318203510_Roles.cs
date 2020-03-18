using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71e2d958-45db-4e8d-b562-21a2d6a91341");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "436ba028-b2de-4ae6-9922-fd41fa29d6af", "8a1985c0-3be3-4bad-a13e-e5a9ec88d8a4", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "436ba028-b2de-4ae6-9922-fd41fa29d6af");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "71e2d958-45db-4e8d-b562-21a2d6a91341", "bdec0caf-74a7-4f08-a7b7-db312a9ee3d6", "Admin", "Admin" });
        }
    }
}
