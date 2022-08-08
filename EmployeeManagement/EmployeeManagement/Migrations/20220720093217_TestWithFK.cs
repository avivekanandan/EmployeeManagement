using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class TestWithFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EployeeId",
                table: "Tests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tests_EployeeId",
                table: "Tests",
                column: "EployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Employees_EployeeId",
                table: "Tests",
                column: "EployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Employees_EployeeId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_EployeeId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "EployeeId",
                table: "Tests");
        }
    }
}
