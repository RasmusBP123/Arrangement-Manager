using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMVYvlmDGgUW68cVhR70M+hvLNb+SDufP/mbtsHx5yI9HjjfgN7Myz2b27pZ06zHjw==");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"),
                column: "StoreId",
                value: new Guid("da868f6a-4f8c-4695-baae-4a0feea05207"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKFD5G4BF9gaZ7MShGkxwTlFaAYjEerlpF/QsTWhrHvIhF3n+ry+9mGIA+abQWtAAQ==");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"),
                column: "StoreId",
                value: null);
        }
    }
}
