using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class Attendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("6d60a26b-17de-4501-a1d1-4b21f564bc63"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Invited = table.Column<int>(nullable: false),
                    Registered = table.Column<int>(nullable: false),
                    NotRegistred = table.Column<int>(nullable: false),
                    MinCustomerAmount = table.Column<int>(nullable: false),
                    MaxCustomerLimit = table.Column<int>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendance_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"), "bd5b9857-9d78-4f9d-81e3-28569973e0a2", new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDev@hotmail.coM", "Rasmus", "Petersen", "ADMINDEV@HOTMAIL.COM", "ADMINDEV@HOTMAIL.COM", "AQAAAAEAACcQAAAAEI+AiD4JZkjLLCJlyCd5O/YF6ph4aafm6+9UjH6XdhoVzg1AboCs3pm3nA0eQqqbew==", "28929173", "f4572cb1-6f71-46fd-8260-0baea7287367", "adminDev@hotmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_EventId",
                table: "Attendance",
                column: "EventId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CreatedDate", "EventId", "UserId" },
                values: new object[] { new Guid("6d60a26b-17de-4501-a1d1-4b21f564bc63"), new DateTime(2019, 12, 4, 11, 20, 0, 0, DateTimeKind.Unspecified), new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"), new Guid("363f53b7-6ee1-4a60-bee9-1af8712551a5") });
        }
    }
}
