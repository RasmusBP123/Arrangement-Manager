using Microsoft.EntityFrameworkCore.Migrations;

namespace Group15.EventManager.Data.Migrations
{
    public partial class Store : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Events_EventId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Employee_EmployeeId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Food_FoodId",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Stores");

            migrationBuilder.RenameIndex(
                name: "IX_Events_FoodId",
                table: "Stores",
                newName: "IX_Stores_FoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_EmployeeId",
                table: "Stores",
                newName: "IX_Stores_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Stores_EventId",
                table: "Customer",
                column: "EventId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Employee_EmployeeId",
                table: "Stores",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Food_FoodId",
                table: "Stores",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Stores_EventId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Employee_EmployeeId",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Food_FoodId",
                table: "Stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_Stores_FoodId",
                table: "Events",
                newName: "IX_Events_FoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Stores_EmployeeId",
                table: "Events",
                newName: "IX_Events_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Events_EventId",
                table: "Customer",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Employee_EmployeeId",
                table: "Events",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Food_FoodId",
                table: "Events",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
