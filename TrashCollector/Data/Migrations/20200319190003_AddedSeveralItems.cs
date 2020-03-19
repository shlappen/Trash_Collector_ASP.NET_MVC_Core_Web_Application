using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedSeveralItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CollectionDay_CollectionDayId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectionDay",
                table: "CollectionDay");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a7e2aff-8316-43de-a7ea-a6da3a89ba90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835c53b2-4c94-4cda-9d3e-c4b5a4d4f916");

            migrationBuilder.RenameTable(
                name: "CollectionDay",
                newName: "CollectionDays");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectionDays",
                table: "CollectionDays",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7805bd6-a117-483c-a248-2071b7a331fa", "2642b1ff-627c-4dd3-adfa-d9d9be64c294", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5660a446-a15f-44eb-93b4-ef234caaec8d", "861251be-fb8e-4277-b276-da9a36470815", "Employee", "Employee" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CollectionDays_CollectionDayId",
                table: "Customers",
                column: "CollectionDayId",
                principalTable: "CollectionDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CollectionDays_CollectionDayId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectionDays",
                table: "CollectionDays");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5660a446-a15f-44eb-93b4-ef234caaec8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7805bd6-a117-483c-a248-2071b7a331fa");

            migrationBuilder.RenameTable(
                name: "CollectionDays",
                newName: "CollectionDay");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectionDay",
                table: "CollectionDay",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a7e2aff-8316-43de-a7ea-a6da3a89ba90", "79537cd2-bd60-4f9c-950e-bdd91819792f", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "835c53b2-4c94-4cda-9d3e-c4b5a4d4f916", "fa494f8d-af90-4a9a-a0fe-9fa8a770758c", "Employee", "Employee" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CollectionDay_CollectionDayId",
                table: "Customers",
                column: "CollectionDayId",
                principalTable: "CollectionDay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
