using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class seeddays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1e0948-b8b8-49ef-8fce-5be892c49fad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df8d215a-46ab-4b17-97ab-a0edf45f7099");

            migrationBuilder.AddColumn<int>(
                name: "CollectionDayId",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CollectionDay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionDay", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c3f4f05a-e780-453b-8a23-a9c709a2bfca", "b4d7e536-e758-46af-9212-968ec8013c02", "Customer", "Customer" },
                    { "0b31c943-b1f3-4bd3-bb04-d8c62d0d3471", "3f97f74e-0d22-4966-9d25-84578f16568f", "Employee", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "CollectionDay",
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
                name: "FK_Customers_CollectionDay_CollectionDayId",
                table: "Customers",
                column: "CollectionDayId",
                principalTable: "CollectionDay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CollectionDay_CollectionDayId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "CollectionDay");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CollectionDayId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b31c943-b1f3-4bd3-bb04-d8c62d0d3471");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f4f05a-e780-453b-8a23-a9c709a2bfca");

            migrationBuilder.DropColumn(
                name: "CollectionDayId",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df8d215a-46ab-4b17-97ab-a0edf45f7099", "0064c568-48ea-4d59-a89e-e8d27676d5e6", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d1e0948-b8b8-49ef-8fce-5be892c49fad", "be6d1446-4e16-4ef2-bb73-259664d2fe84", "Employee", "Employee" });
        }
    }
}
