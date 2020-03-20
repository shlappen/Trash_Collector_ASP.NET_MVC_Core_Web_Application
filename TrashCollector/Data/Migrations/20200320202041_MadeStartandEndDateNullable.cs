using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class MadeStartandEndDateNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81fba3e8-e707-4822-a4ec-f7911947482b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3c91fab-42a7-44a3-bb21-00ab27b17cc3");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fd53ef4-91b2-4ef1-99bd-2ff6ec2f4df1", "00cf5c9f-6eaa-439a-9133-4826518f9bed", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89047a7f-0d43-47fe-a108-9ea205ff22db", "b448db86-c453-418e-a952-0602d02b071f", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fd53ef4-91b2-4ef1-99bd-2ff6ec2f4df1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89047a7f-0d43-47fe-a108-9ea205ff22db");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81fba3e8-e707-4822-a4ec-f7911947482b", "8f449b60-2a7f-45cf-9e1c-7d6b4b6c28e3", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3c91fab-42a7-44a3-bb21-00ab27b17cc3", "c9b4d0ad-1a55-4237-91dc-621ec4d90949", "Employee", "Employee" });
        }
    }
}
