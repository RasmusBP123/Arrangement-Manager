using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class addedMarkerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "X",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "Address");

            migrationBuilder.AddColumn<Guid>(
                name: "MarkerId",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MarkerId",
                table: "Event",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Markers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPD56O6pJTXk4DSOSQ4WxuyZxQkJ3uSSfAzkLy2pW1yIKwx6Uybxa+n+RzPhdmRxVg==");

            migrationBuilder.InsertData(
                table: "Markers",
                columns: new[] { "Id", "CreatedDate", "X", "Y" },
                values: new object[] { new Guid("82751c12-b1f9-4d4e-a806-0ea07dd291d7"), new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.379875, 55.394002999999998 });

            migrationBuilder.InsertData(
                table: "Markers",
                columns: new[] { "Id", "CreatedDate", "X", "Y" },
                values: new object[] { new Guid("847fea10-80f0-49a0-8997-409eafdb5892"), new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.369267000000001, 55.427731000000001 });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"),
                column: "MarkerId",
                value: new Guid("847fea10-80f0-49a0-8997-409eafdb5892"));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("da868f6a-4f8c-4695-baae-4a0feea05207"),
                column: "MarkerId",
                value: new Guid("82751c12-b1f9-4d4e-a806-0ea07dd291d7"));

            migrationBuilder.CreateIndex(
                name: "IX_Stores_MarkerId",
                table: "Stores",
                column: "MarkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_MarkerId",
                table: "Event",
                column: "MarkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Markers_MarkerId",
                table: "Event",
                column: "MarkerId",
                principalTable: "Markers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Markers_MarkerId",
                table: "Stores",
                column: "MarkerId",
                principalTable: "Markers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Markers_MarkerId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Markers_MarkerId",
                table: "Stores");

            migrationBuilder.DropTable(
                name: "Markers");

            migrationBuilder.DropIndex(
                name: "IX_Stores_MarkerId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Event_MarkerId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "MarkerId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "MarkerId",
                table: "Event");

            migrationBuilder.AddColumn<double>(
                name: "X",
                table: "Address",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Y",
                table: "Address",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: new Guid("19bcfcf0-4dd1-4f7e-8591-4697628fed9a"),
                columns: new[] { "X", "Y" },
                values: new object[] { 12.02, 7.0499999999999998 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOVjWOoV9iBnWsnpG1CZU8E7jIYZXev+/9hjyYU5idC/iaPQnimXMKr7vaAVaUXVWg==");
        }
    }
}
