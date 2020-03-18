using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "436ba028-b2de-4ae6-9922-fd41fa29d6af");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df8d215a-46ab-4b17-97ab-a0edf45f7099", "0064c568-48ea-4d59-a89e-e8d27676d5e6", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d1e0948-b8b8-49ef-8fce-5be892c49fad", "be6d1446-4e16-4ef2-bb73-259664d2fe84", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1e0948-b8b8-49ef-8fce-5be892c49fad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df8d215a-46ab-4b17-97ab-a0edf45f7099");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "436ba028-b2de-4ae6-9922-fd41fa29d6af", "8a1985c0-3be3-4bad-a13e-e5a9ec88d8a4", "Admin", "Admin" });
        }
    }
}
