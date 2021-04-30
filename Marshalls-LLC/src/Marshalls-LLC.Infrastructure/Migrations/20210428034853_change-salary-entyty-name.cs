using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class changesalaryentytyname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: true),
                    DivisionId = table.Column<int>(type: "int", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseSalary = table.Column<double>(type: "float", nullable: false),
                    ProductionBonus = table.Column<double>(type: "float", nullable: false),
                    CompensationBonus = table.Column<double>(type: "float", nullable: false),
                    Commission = table.Column<double>(type: "float", nullable: false),
                    Contributions = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DivisionId",
                table: "Employee",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_OfficeId",
                table: "Employee",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionId",
                table: "Employee",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseSalary = table.Column<double>(type: "float", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Commission = table.Column<double>(type: "float", nullable: false),
                    CompensationBonus = table.Column<double>(type: "float", nullable: false),
                    Contributions = table.Column<double>(type: "float", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: true),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    ProductionBonus = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salary_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Salary_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Salary_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Salary_DivisionId",
                table: "Salary",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_EmployeeName",
                table: "Salary",
                column: "EmployeeName");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_OfficeId",
                table: "Salary",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_PositionId",
                table: "Salary",
                column: "PositionId");
        }
    }
}
