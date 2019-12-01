using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class eventseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedDate", "Name", "StoreId" },
                values: new object[] { new Guid("3216b7c9-4b42-44b4-a49c-2117496983d4"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Torsten Jakobsen", new Guid("da868f6a-4f8c-4695-baae-4a0feea05207") });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "AddressId", "CityId", "CreatedDate", "Description", "EmployeeId", "EndEventDate", "EventDate", "FoodId", "Image", "LastBookingDate", "MaxCustomerLimit", "MinCustomerAmount", "Name", "PayOnline", "Price", "RegionId" },
                values: new object[] { new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"), new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"), new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eventet kommer til at foregå i Odense kl. 16:00, hvor man vil få tilbudt forfriskninger og vin til maden", new Guid("3216b7c9-4b42-44b4-a49c-2117496983d4"), new DateTime(2019, 12, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 24, 14, 30, 0, 0, DateTimeKind.Unspecified), new Guid("5384338e-ff12-4a9a-8789-b3d89ce5db26"), new byte[] { 0 }, new DateTime(2019, 12, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 200, 50, "Vinsmagning i hyggelige omgivelser", true, 700.0, new Guid("7e07ff02-61b5-47cf-80d2-95af4c291274") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3216b7c9-4b42-44b4-a49c-2117496983d4"));
        }
    }
}
