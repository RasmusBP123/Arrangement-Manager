using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class updatedDataModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Stores_StoreId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StoreId",
                table: "AspNetUsers");

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

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RegionId",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SiteId",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastBookingDate",
                table: "Event",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MinCustomerAmount",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PayOnline",
                table: "Event",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    RoadName = table.Column<string>(nullable: true),
                    RoadNumber = table.Column<int>(nullable: false),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Stores_CityId",
                table: "Stores",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_RegionId",
                table: "Stores",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_SiteId",
                table: "Stores",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_AddressId",
                table: "Event",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Address_AddressId",
                table: "Event",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Cities_CityId",
                table: "Stores",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Regions_RegionId",
                table: "Stores",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Address_SiteId",
                table: "Stores",
                column: "SiteId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Address_AddressId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Cities_CityId",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Regions_RegionId",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Address_SiteId",
                table: "Stores");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Stores_CityId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_RegionId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_SiteId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Event_AddressId",
                table: "Event");

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

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "LastBookingDate",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "MinCustomerAmount",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "PayOnline",
                table: "Event");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StoreId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StoreId",
                table: "AspNetUsers",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Stores_StoreId",
                table: "AspNetUsers",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
