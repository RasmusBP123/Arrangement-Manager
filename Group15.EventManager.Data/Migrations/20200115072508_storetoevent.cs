using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class storetoevent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StoreId",
                table: "Event",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDRsMoVLg6Oma8hjmjcPodcwj0FWlBGU5PKTbrBHZyBMHatpyn3RHGQibJILskp6fg==");

            migrationBuilder.CreateIndex(
                name: "IX_Event_StoreId",
                table: "Event",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Stores_StoreId",
                table: "Event",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Stores_StoreId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_StoreId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI+uaUXQ2gOwvegvJOBwLZUeQwE2Tb/A/+BlUHv1AgdcsInYKsrRPkgs9dIZUpra4g==");
        }
    }
}
