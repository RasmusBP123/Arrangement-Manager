using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Group15.EventManager.Data.Migrations
{
    public partial class currentAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("6d60a26b-17de-4501-a1d1-4b21f564bc63"),
                column: "UserId",
                value: new Guid("363f53b7-6ee1-4a60-bee9-1af8712551a5"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("6d60a26b-17de-4501-a1d1-4b21f564bc63"),
                column: "UserId",
                value: new Guid("20b193c3-9de6-42b1-aacf-56f6d860e418"));
        }
    }
}
