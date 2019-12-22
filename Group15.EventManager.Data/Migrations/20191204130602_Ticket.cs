using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Group15.EventManager.Data.Migrations
{
    public partial class Ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("6d60a26b-17de-4501-a1d1-4b21f564bc63"),
                column: "UserId",
                value: new Guid("20b193c3-9de6-42b1-aacf-56f6d860e418"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("6d60a26b-17de-4501-a1d1-4b21f564bc63"),
                column: "UserId",
                value: new Guid("4366b15f-1346-4754-8517-08d77808f56a"));
        }
    }
}
