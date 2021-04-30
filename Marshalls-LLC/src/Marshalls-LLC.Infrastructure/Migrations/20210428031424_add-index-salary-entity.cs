using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class addindexsalaryentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeName",
                table: "Salary",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salary_EmployeeName",
                table: "Salary",
                column: "EmployeeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Salary_EmployeeName",
                table: "Salary");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeName",
                table: "Salary",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
