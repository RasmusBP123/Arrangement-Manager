using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Group15.EventManager.Data.Migrations
{
    public partial class groups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Discount = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    ApplicationUserId = table.Column<Guid>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => new { x.ApplicationUserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_UserGroups_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIe2xCqtGsu/ByT2WLR+DX7TNS45db0vjLjRpXShe2wBOiQomVDALzGNrJ+YcU0ENQ==");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"),
                column: "Name",
                value: "Odense");

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CreatedDate", "Discount", "Name" },
                values: new object[,]
                {
                    { new Guid("4bca98a6-3cd0-49da-a947-02ad2ef8cdf5"), new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.0, "Basic" },
                    { new Guid("cf113457-a62f-4ed5-ae65-d5d4ebc09537"), new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, "Member" },
                    { new Guid("0daeaea2-2e4e-49f7-be7b-d61724c60971"), new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, "Business" },
                    { new Guid("dba67215-9771-457d-9698-d7dc708a00e7"), new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 55.0, "Premium" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_GroupId",
                table: "UserGroups",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPD56O6pJTXk4DSOSQ4WxuyZxQkJ3uSSfAzkLy2pW1yIKwx6Uybxa+n+RzPhdmRxVg==");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("264d9f3b-ee5a-4436-8f5e-9937a9ff4727"),
                column: "Name",
                value: "Fyn");
        }
    }
}
