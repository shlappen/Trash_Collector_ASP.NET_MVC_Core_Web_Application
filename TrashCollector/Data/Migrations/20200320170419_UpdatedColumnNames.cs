using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatedColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "799cef0f-d5fc-446c-86ef-8e90e00842a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebe87082-a4e6-458d-b099-cb4409a6cac7");

            migrationBuilder.RenameColumn(
                name: "Zipcode",
                table: "Employees",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "Zipcode",
                table: "Customers",
                newName: "ZipCode");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Customers",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7458920c-331d-4d70-ac23-729b6116af8c", "71f2f9c9-cb54-4c49-b130-a5015ee593a2", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bf60982-1ad8-4821-8cae-9b451cf65336", "904c1a98-9567-4fbb-8d43-f17cceef81ae", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7458920c-331d-4d70-ac23-729b6116af8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bf60982-1ad8-4821-8cae-9b451cf65336");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Employees",
                newName: "Zipcode");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Customers",
                newName: "Zipcode");

            migrationBuilder.AlterColumn<int>(
                name: "Zipcode",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebe87082-a4e6-458d-b099-cb4409a6cac7", "d401931a-936e-45bf-b19d-a63d657f4c23", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "799cef0f-d5fc-446c-86ef-8e90e00842a6", "bff5c98e-3a80-4b0e-ab14-068fa4d5ba2e", "Employee", "Employee" });
        }
    }
}
