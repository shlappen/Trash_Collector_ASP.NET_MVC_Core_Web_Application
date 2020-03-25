using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addeddateconfirmationproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b43266c-4f19-4311-b792-b68d234ad815");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96be4f7f-65f4-4bef-a173-6f9ca2e825db");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExtraCollectionDayConfirmation",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PickupConfirmationDate",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5af232a0-1c9d-41f3-9a3d-f4db95106112", "6fe44a1c-f846-4c83-a8cf-f01d2cd1874e", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68fd7664-b2c4-48a0-9012-9e680c886514", "22108508-eccc-4499-be2e-aca6bf83f03d", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5af232a0-1c9d-41f3-9a3d-f4db95106112");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68fd7664-b2c4-48a0-9012-9e680c886514");

            migrationBuilder.DropColumn(
                name: "ExtraCollectionDayConfirmation",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PickupConfirmationDate",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96be4f7f-65f4-4bef-a173-6f9ca2e825db", "64b11582-ffb7-49cc-be64-1a983021b249", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b43266c-4f19-4311-b792-b68d234ad815", "6e9c430b-df26-420c-b18c-815413918f59", "Employee", "Employee" });
        }
    }
}
