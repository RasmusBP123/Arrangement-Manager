using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class updatedDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c6fa6f5-c9aa-4760-a15f-f95a70e667e7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b17e0958-7c66-49e3-9897-e8c7dea569bb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "be355016-857c-4d09-aaae-f6564f12fe0b");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "490aca4c-0af7-4eb2-aeb5-43679db996b7", "0cfc47a9-ec7f-4c7e-a218-248c97ef2542", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36044d1f-8c28-4b41-8233-d6b64944e08d", "ff935111-1d5a-4e75-87e2-451a4ee84d23", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f5718c82-75fa-4068-ba12-43e820690581", "4e4db971-7d73-45f5-92d1-cf0c496b6a99", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "36044d1f-8c28-4b41-8233-d6b64944e08d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "490aca4c-0af7-4eb2-aeb5-43679db996b7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f5718c82-75fa-4068-ba12-43e820690581");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b17e0958-7c66-49e3-9897-e8c7dea569bb", "31dcc43e-cb01-47be-88c9-fe2a330daca4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be355016-857c-4d09-aaae-f6564f12fe0b", "e683817e-bf57-4610-9b42-bb4f4193a08d", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c6fa6f5-c9aa-4760-a15f-f95a70e667e7", "31c0805c-d288-46ee-be98-514cee6f593b", "User", "USER" });
        }
    }
}
