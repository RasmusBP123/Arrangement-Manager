using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class storeseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "CreatedDate", "RoadName", "RoadNumber", "X", "Y" },
                values: new object[] { new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bredgade", 1, 12.02, 7.0499999999999998 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedDate", "Name", "Price" },
                values: new object[] { new Guid("5384338e-ff12-4a9a-8789-b3d89ce5db26"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stegt and", 249.94999999999999 });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressId", "CityId", "CreatedDate", "Name", "RegionId" },
                values: new object[] { new Guid("da868f6a-4f8c-4695-baae-4a0feea05207"), new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"), new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odense Vinbutik", new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("5384338e-ff12-4a9a-8789-b3d89ce5db26"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("da868f6a-4f8c-4695-baae-4a0feea05207"));

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"));
        }
    }
}
