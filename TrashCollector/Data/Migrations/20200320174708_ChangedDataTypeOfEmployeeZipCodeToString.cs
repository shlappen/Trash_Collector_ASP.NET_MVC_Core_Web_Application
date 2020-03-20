using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class ChangedDataTypeOfEmployeeZipCodeToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96e86dda-84ca-4bcc-a972-34e22d5c5e10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c210170-d99c-438d-9364-e3984b417292");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17d0d96b-c967-4bbc-b2b7-b89cc3ab0b74", "68706e40-4da2-4150-9a96-d3dd9127abcc", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48237b0f-330b-43b6-bd7b-344639b8f9e1", "125fc765-6b08-43ab-9713-c44ad975acf3", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d0d96b-c967-4bbc-b2b7-b89cc3ab0b74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48237b0f-330b-43b6-bd7b-344639b8f9e1");

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96e86dda-84ca-4bcc-a972-34e22d5c5e10", "62fe3238-68a2-4fd3-ab1e-94a741f1ff2a", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c210170-d99c-438d-9364-e3984b417292", "88379c28-5690-4f78-bb98-07f95f9ea860", "Employee", "Employee" });
        }
    }
}
