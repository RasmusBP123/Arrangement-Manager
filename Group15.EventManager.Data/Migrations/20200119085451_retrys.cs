using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class retrys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AttendanceId",
                table: "Event",
                nullable: true);

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
                column: "AttendanceId",
                value: new Guid("2300cd37-5bf0-436a-1136-08d798f22ccd"));

            migrationBuilder.CreateIndex(
                name: "IX_Event_AttendanceId",
                table: "Event",
                column: "AttendanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Attendance_AttendanceId",
                table: "Event",
                column: "AttendanceId",
                principalTable: "Attendance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Attendance_AttendanceId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_AttendanceId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "AttendanceId",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECsMS7T6ThnWMx1a2DgFvV7IQn2hRPuLGzKNSSFssHwDfm2ffNgDRtmWa2+4S/at6w==");
        }
    }
}
