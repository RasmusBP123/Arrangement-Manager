using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Group15.EventManager.Data.Migrations
{
    public partial class finished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "Attendance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOVjWOoV9iBnWsnpG1CZU8E7jIYZXev+/9hjyYU5idC/iaPQnimXMKr7vaAVaUXVWg==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finished",
                table: "Attendance");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI+AiD4JZkjLLCJlyCd5O/YF6ph4aafm6+9UjH6XdhoVzg1AboCs3pm3nA0eQqqbew==");
        }
    }
}
