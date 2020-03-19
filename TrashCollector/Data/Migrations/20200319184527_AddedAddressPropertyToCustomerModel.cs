using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedAddressPropertyToCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b31c943-b1f3-4bd3-bb04-d8c62d0d3471");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f4f05a-e780-453b-8a23-a9c709a2bfca");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a7e2aff-8316-43de-a7ea-a6da3a89ba90", "79537cd2-bd60-4f9c-950e-bdd91819792f", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "835c53b2-4c94-4cda-9d3e-c4b5a4d4f916", "fa494f8d-af90-4a9a-a0fe-9fa8a770758c", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a7e2aff-8316-43de-a7ea-a6da3a89ba90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835c53b2-4c94-4cda-9d3e-c4b5a4d4f916");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3f4f05a-e780-453b-8a23-a9c709a2bfca", "b4d7e536-e758-46af-9212-968ec8013c02", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b31c943-b1f3-4bd3-bb04-d8c62d0d3471", "3f97f74e-0d22-4966-9d25-84578f16568f", "Employee", "Employee" });
        }
    }
}
