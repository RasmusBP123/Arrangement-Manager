using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class usereventRedo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Event_ApplicationUserId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_AspNetUsers_EventId",
                table: "UserEvents");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c9d411b-0bfe-4d29-bf3c-abf4d61bf23f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6d95764c-dc3b-4027-96ef-6170d33d4c00");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f06917d1-a2be-4950-8304-b3730d8c1e48");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19f981ea-63e4-4be5-a38e-9a95cdace32f", "6263e57c-2036-4644-b01a-9cfa57fb4c18", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa1acf7d-e971-4ae3-a14b-c5e9c767fee5", "8308ac49-1172-4415-8a33-128fce105c04", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1e5d821-aa74-4d26-9a2c-a5a49daea15b", "f2a4441d-0d54-408f-a9a5-67aa8f0e902e", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_AspNetUsers_ApplicationUserId",
                table: "UserEvents",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Event_EventId",
                table: "UserEvents",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_AspNetUsers_ApplicationUserId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Event_EventId",
                table: "UserEvents");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "19f981ea-63e4-4be5-a38e-9a95cdace32f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e1e5d821-aa74-4d26-9a2c-a5a49daea15b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "aa1acf7d-e971-4ae3-a14b-c5e9c767fee5");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f06917d1-a2be-4950-8304-b3730d8c1e48", "be9f9fb7-587b-4da0-b9cd-eaa56e6e3013", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d95764c-dc3b-4027-96ef-6170d33d4c00", "a2832e06-3fbd-4fb9-97d6-3bfa1e3a1edd", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c9d411b-0bfe-4d29-bf3c-abf4d61bf23f", "0122b8c5-7226-45b9-ad59-08bc9725ebc7", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Event_ApplicationUserId",
                table: "UserEvents",
                column: "ApplicationUserId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_AspNetUsers_EventId",
                table: "UserEvents",
                column: "EventId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
