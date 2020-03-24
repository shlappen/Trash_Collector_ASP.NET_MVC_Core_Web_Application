using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addedbalancetocustomermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fd53ef4-91b2-4ef1-99bd-2ff6ec2f4df1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89047a7f-0d43-47fe-a108-9ea205ff22db");

            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Customers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96be4f7f-65f4-4bef-a173-6f9ca2e825db", "64b11582-ffb7-49cc-be64-1a983021b249", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b43266c-4f19-4311-b792-b68d234ad815", "6e9c430b-df26-420c-b18c-815413918f59", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b43266c-4f19-4311-b792-b68d234ad815");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96be4f7f-65f4-4bef-a173-6f9ca2e825db");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fd53ef4-91b2-4ef1-99bd-2ff6ec2f4df1", "00cf5c9f-6eaa-439a-9133-4826518f9bed", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89047a7f-0d43-47fe-a108-9ea205ff22db", "b448db86-c453-418e-a952-0602d02b071f", "Employee", "Employee" });
        }
    }
}
