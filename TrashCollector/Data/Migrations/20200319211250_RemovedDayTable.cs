using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class RemovedDayTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CollectionDays_CollectionDayId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "CollectionDays");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CollectionDayId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5660a446-a15f-44eb-93b4-ef234caaec8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7805bd6-a117-483c-a248-2071b7a331fa");

            migrationBuilder.DropColumn(
                name: "CollectionDayId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CollectionDay",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExtraCollectionDay",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3d26dd8-df32-4037-8628-7eb8cbcb88da", "6302fd66-2cd4-4880-9f86-c77a68e61d71", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7af5893e-2148-448c-8d7a-3d6f7a9980ee", "64205942-6a06-43e1-8c48-0392db91c131", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7af5893e-2148-448c-8d7a-3d6f7a9980ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3d26dd8-df32-4037-8628-7eb8cbcb88da");

            migrationBuilder.DropColumn(
                name: "CollectionDay",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ExtraCollectionDay",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CollectionDayId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CollectionDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionDays", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f7805bd6-a117-483c-a248-2071b7a331fa", "2642b1ff-627c-4dd3-adfa-d9d9be64c294", "Customer", "Customer" },
                    { "5660a446-a15f-44eb-93b4-ef234caaec8d", "861251be-fb8e-4277-b276-da9a36470815", "Employee", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "CollectionDays",
                columns: new[] { "Id", "Day" },
                values: new object[,]
                {
                    { 1, "Sunday" },
                    { 2, "Monday" },
                    { 3, "Tuesday" },
                    { 4, "Wednesday" },
                    { 5, "Thursday" },
                    { 6, "Friday" },
                    { 7, "Saturday" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CollectionDayId",
                table: "Customers",
                column: "CollectionDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CollectionDays_CollectionDayId",
                table: "Customers",
                column: "CollectionDayId",
                principalTable: "CollectionDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
