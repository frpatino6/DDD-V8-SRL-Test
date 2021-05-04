using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 4, 29, 22, 12, 0, 416, DateTimeKind.Local).AddTicks(2952)),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BaseSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductionBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompensationBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Commission = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Contributions = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Division",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Manager" },
                    { 1, "Operation" }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Recursos Humanos" },
                    { 2, "IT" },
                    { 3, "Gerencia en tecnologia" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Cargo assistant" },
                    { 2, "Head of cargo" },
                    { 1, "Cargo Manager" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 1, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 411, DateTimeKind.Local).AddTicks(2332), new DateTime(1970, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "5765", "Dana", "Dantin", 7, "66714294", 1, 1, 2, 500m, 2020 },
                    { 56, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2762), new DateTime(1991, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "15315", "Pat", "Demmert", 16, "28342246", 2, 1, 1, 200m, 2020 },
                    { 55, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2762), new DateTime(1991, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "15315", "Pat", "Demmert", 16, "28342246", 1, 1, 1, 200m, 2020 },
                    { 42, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2212), new DateTime(1971, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "56876", "Leigh", "Bynum", 9, "49527295", 6, 1, 1, 250m, 2020 },
                    { 41, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2212), new DateTime(1971, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "56876", "Leigh", "Bynum", 9, "49527295", 5, 1, 1, 250m, 2020 },
                    { 40, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2212), new DateTime(1971, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "56876", "Leigh", "Bynum", 9, "49527295", 4, 1, 1, 250m, 2020 },
                    { 39, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2212), new DateTime(1971, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "56876", "Leigh", "Bynum", 9, "49527295", 3, 1, 1, 250m, 2020 },
                    { 38, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2212), new DateTime(1971, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "56876", "Leigh", "Bynum", 9, "49527295", 2, 1, 1, 250m, 2020 },
                    { 37, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2212), new DateTime(1971, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "56876", "Leigh", "Bynum", 9, "49527295", 1, 1, 1, 250m, 2020 },
                    { 36, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2057), new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "84299", "Jules", "Lamberth", 8, "85856549", 6, 2, 1, 300m, 2020 },
                    { 35, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2057), new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "84299", "Jules", "Lamberth", 8, "85856549", 5, 2, 1, 300m, 2020 },
                    { 34, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2057), new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "84299", "Jules", "Lamberth", 8, "85856549", 4, 2, 1, 300m, 2020 },
                    { 33, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2057), new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "84299", "Jules", "Lamberth", 8, "85856549", 3, 2, 1, 300m, 2020 },
                    { 32, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2057), new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "84299", "Jules", "Lamberth", 8, "85856549", 2, 2, 1, 300m, 2020 },
                    { 31, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2057), new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "84299", "Jules", "Lamberth", 8, "85856549", 1, 2, 1, 300m, 2020 },
                    { 12, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1420), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "48039", "Douglass", "Nodurft", 9, "23574894", 6, 2, 1, 500m, 2020 },
                    { 11, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1420), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "48039", "Douglass", "Nodurft", 9, "23574894", 5, 2, 1, 500m, 2020 },
                    { 10, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1420), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "48039", "Douglass", "Nodurft", 9, "23574894", 4, 2, 1, 500m, 2020 },
                    { 9, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1420), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "48039", "Douglass", "Nodurft", 9, "23574894", 3, 2, 1, 500m, 2020 },
                    { 8, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1420), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "48039", "Douglass", "Nodurft", 9, "23574894", 2, 2, 1, 500m, 2020 },
                    { 7, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1420), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "48039", "Douglass", "Nodurft", 9, "23574894", 1, 2, 1, 500m, 2020 },
                    { 96, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3451), new DateTime(1971, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "88701", "Drew", "Burket", 7, "39308104", 6, 2, 2, 300m, 2020 },
                    { 57, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2762), new DateTime(1991, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "15315", "Pat", "Demmert", 16, "28342246", 3, 1, 1, 200m, 2020 },
                    { 58, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2762), new DateTime(1991, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "15315", "Pat", "Demmert", 16, "28342246", 4, 1, 1, 200m, 2020 },
                    { 59, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2762), new DateTime(1991, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "15315", "Pat", "Demmert", 16, "28342246", 5, 1, 1, 200m, 2020 },
                    { 60, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2762), new DateTime(1991, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "15315", "Pat", "Demmert", 16, "28342246", 6, 1, 1, 200m, 2020 },
                    { 100, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3548), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "58030", "Alfonzo", "Treece", 17, "78891667", 4, 2, 1, 250m, 2020 },
                    { 99, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3548), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "58030", "Alfonzo", "Treece", 17, "78891667", 3, 2, 1, 250m, 2020 },
                    { 98, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3548), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "58030", "Alfonzo", "Treece", 17, "78891667", 2, 2, 1, 250m, 2020 },
                    { 97, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3548), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "58030", "Alfonzo", "Treece", 17, "78891667", 1, 2, 1, 250m, 2020 },
                    { 90, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3322), new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "71776", "Stewart", "Demonbreun", 8, "37963304", 6, 1, 1, 350m, 2020 },
                    { 89, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3322), new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "71776", "Stewart", "Demonbreun", 8, "37963304", 5, 1, 1, 350m, 2020 },
                    { 88, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3322), new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "71776", "Stewart", "Demonbreun", 8, "37963304", 4, 1, 1, 350m, 2020 },
                    { 87, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3322), new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "71776", "Stewart", "Demonbreun", 8, "37963304", 3, 1, 1, 350m, 2020 },
                    { 86, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3322), new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "71776", "Stewart", "Demonbreun", 8, "37963304", 2, 1, 1, 350m, 2020 },
                    { 85, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3322), new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "71776", "Stewart", "Demonbreun", 8, "37963304", 1, 1, 1, 350m, 2020 },
                    { 95, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3451), new DateTime(1971, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "88701", "Drew", "Burket", 7, "39308104", 5, 2, 2, 300m, 2020 },
                    { 84, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3224), new DateTime(1992, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "38498", "Scott", "Vanbrunt", 12, "31445341", 6, 1, 1, 200m, 2020 },
                    { 82, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3224), new DateTime(1992, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "38498", "Scott", "Vanbrunt", 12, "31445341", 4, 1, 1, 200m, 2020 },
                    { 81, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3224), new DateTime(1992, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "38498", "Scott", "Vanbrunt", 12, "31445341", 3, 1, 1, 200m, 2020 },
                    { 80, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3224), new DateTime(1992, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "38498", "Scott", "Vanbrunt", 12, "31445341", 2, 1, 1, 200m, 2020 },
                    { 79, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3224), new DateTime(1992, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "38498", "Scott", "Vanbrunt", 12, "31445341", 1, 1, 1, 200m, 2020 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 72, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2998), new DateTime(1975, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "65473", "Fermin", "Koberg", 17, "79732648", 6, 1, 1, 500m, 2020 },
                    { 71, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2998), new DateTime(1975, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "65473", "Fermin", "Koberg", 17, "79732648", 5, 1, 1, 500m, 2020 },
                    { 70, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2998), new DateTime(1975, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "65473", "Fermin", "Koberg", 17, "79732648", 4, 1, 1, 500m, 2020 },
                    { 69, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2998), new DateTime(1975, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "65473", "Fermin", "Koberg", 17, "79732648", 3, 1, 1, 500m, 2020 },
                    { 68, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2998), new DateTime(1975, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "65473", "Fermin", "Koberg", 17, "79732648", 2, 1, 1, 500m, 2020 },
                    { 67, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2998), new DateTime(1975, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "65473", "Fermin", "Koberg", 17, "79732648", 1, 1, 1, 500m, 2020 },
                    { 83, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3224), new DateTime(1992, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "38498", "Scott", "Vanbrunt", 12, "31445341", 5, 1, 1, 200m, 2020 },
                    { 94, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3451), new DateTime(1971, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "88701", "Drew", "Burket", 7, "39308104", 4, 2, 2, 300m, 2020 },
                    { 93, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3451), new DateTime(1971, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "88701", "Drew", "Burket", 7, "39308104", 3, 2, 2, 300m, 2020 },
                    { 92, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3451), new DateTime(1971, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "88701", "Drew", "Burket", 7, "39308104", 2, 2, 2, 300m, 2020 },
                    { 29, 7000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1944), new DateTime(1963, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "89183", "Bret", "Simien", 10, "80418278", 5, 2, 2, 700m, 2020 },
                    { 28, 7000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1944), new DateTime(1963, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "89183", "Bret", "Simien", 10, "80418278", 4, 2, 2, 700m, 2020 },
                    { 27, 7000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1944), new DateTime(1963, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "89183", "Bret", "Simien", 10, "80418278", 3, 2, 2, 700m, 2020 },
                    { 26, 7000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1944), new DateTime(1963, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "89183", "Bret", "Simien", 10, "80418278", 2, 2, 2, 700m, 2020 },
                    { 25, 7000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1944), new DateTime(1963, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "89183", "Bret", "Simien", 10, "80418278", 1, 2, 2, 700m, 2020 },
                    { 24, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1821), new DateTime(1960, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "51292", "Alfonso", "Stitely", 17, "76327130", 6, 1, 2, 350m, 2020 },
                    { 23, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1821), new DateTime(1960, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "51292", "Alfonso", "Stitely", 17, "76327130", 5, 1, 2, 350m, 2020 },
                    { 22, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1821), new DateTime(1960, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "51292", "Alfonso", "Stitely", 17, "76327130", 4, 1, 2, 350m, 2020 },
                    { 21, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1821), new DateTime(1960, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "51292", "Alfonso", "Stitely", 17, "76327130", 3, 1, 2, 350m, 2020 },
                    { 20, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1821), new DateTime(1960, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "51292", "Alfonso", "Stitely", 17, "76327130", 2, 1, 2, 350m, 2020 },
                    { 30, 7000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1944), new DateTime(1963, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "89183", "Bret", "Simien", 10, "80418278", 6, 2, 2, 700m, 2020 },
                    { 19, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1821), new DateTime(1960, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "51292", "Alfonso", "Stitely", 17, "76327130", 1, 1, 2, 350m, 2020 },
                    { 17, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1621), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "85261", "Everette", "Loberg", 13, "91054267", 5, 2, 2, 300m, 2020 },
                    { 16, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1621), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "85261", "Everette", "Loberg", 13, "91054267", 4, 2, 2, 300m, 2020 },
                    { 15, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1621), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "85261", "Everette", "Loberg", 13, "91054267", 3, 2, 2, 300m, 2020 },
                    { 14, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1621), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "85261", "Everette", "Loberg", 13, "91054267", 2, 2, 2, 300m, 2020 },
                    { 13, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1621), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "85261", "Everette", "Loberg", 13, "91054267", 1, 2, 2, 300m, 2020 },
                    { 6, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 411, DateTimeKind.Local).AddTicks(2332), new DateTime(1970, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "5765", "Dana", "Dantin", 7, "66714294", 6, 1, 2, 500m, 2020 },
                    { 5, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 411, DateTimeKind.Local).AddTicks(2332), new DateTime(1970, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "5765", "Dana", "Dantin", 7, "66714294", 5, 1, 2, 500m, 2020 },
                    { 4, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 411, DateTimeKind.Local).AddTicks(2332), new DateTime(1970, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "5765", "Dana", "Dantin", 7, "66714294", 4, 1, 2, 500m, 2020 },
                    { 3, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 411, DateTimeKind.Local).AddTicks(2332), new DateTime(1970, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "5765", "Dana", "Dantin", 7, "66714294", 3, 1, 2, 500m, 2020 },
                    { 2, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 411, DateTimeKind.Local).AddTicks(2332), new DateTime(1970, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "5765", "Dana", "Dantin", 7, "66714294", 2, 1, 2, 500m, 2020 },
                    { 18, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(1621), new DateTime(1987, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "85261", "Everette", "Loberg", 13, "91054267", 6, 2, 2, 300m, 2020 },
                    { 101, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3548), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "58030", "Alfonzo", "Treece", 17, "78891667", 5, 2, 1, 250m, 2020 },
                    { 43, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2361), new DateTime(1995, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "35262", "Gregory", "Canak", 15, "27456179", 1, 1, 2, 350m, 2020 },
                    { 45, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2361), new DateTime(1995, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "35262", "Gregory", "Canak", 15, "27456179", 3, 1, 2, 350m, 2020 },
                    { 91, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3451), new DateTime(1971, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "88701", "Drew", "Burket", 7, "39308104", 1, 2, 2, 300m, 2020 },
                    { 78, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3096), new DateTime(1968, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "92033", "Long", "Ellenburg", 7, "88860875", 6, 2, 2, 200m, 2020 },
                    { 77, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3096), new DateTime(1968, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "92033", "Long", "Ellenburg", 7, "88860875", 5, 2, 2, 200m, 2020 },
                    { 76, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3096), new DateTime(1968, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "92033", "Long", "Ellenburg", 7, "88860875", 4, 2, 2, 200m, 2020 },
                    { 75, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3096), new DateTime(1968, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "92033", "Long", "Ellenburg", 7, "88860875", 3, 2, 2, 200m, 2020 },
                    { 74, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3096), new DateTime(1968, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "92033", "Long", "Ellenburg", 7, "88860875", 2, 2, 2, 200m, 2020 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 73, 2000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3096), new DateTime(1968, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "92033", "Long", "Ellenburg", 7, "88860875", 1, 2, 2, 200m, 2020 },
                    { 66, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2865), new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "6052", "Earl", "Sansalone", 13, "44327209", 6, 2, 2, 300m, 2020 },
                    { 65, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2865), new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "6052", "Earl", "Sansalone", 13, "44327209", 5, 2, 2, 300m, 2020 },
                    { 64, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2865), new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "6052", "Earl", "Sansalone", 13, "44327209", 4, 2, 2, 300m, 2020 },
                    { 44, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2361), new DateTime(1995, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "35262", "Gregory", "Canak", 15, "27456179", 2, 1, 2, 350m, 2020 },
                    { 63, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2865), new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "6052", "Earl", "Sansalone", 13, "44327209", 3, 2, 2, 300m, 2020 },
                    { 61, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2865), new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "6052", "Earl", "Sansalone", 13, "44327209", 1, 2, 2, 300m, 2020 },
                    { 54, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2638), new DateTime(1981, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "47546", "Federico", "Villescaz", 12, "51666632", 6, 1, 2, 500m, 2020 },
                    { 53, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2638), new DateTime(1981, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "47546", "Federico", "Villescaz", 12, "51666632", 5, 1, 2, 500m, 2020 },
                    { 52, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2638), new DateTime(1981, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "47546", "Federico", "Villescaz", 12, "51666632", 4, 1, 2, 500m, 2020 },
                    { 51, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2638), new DateTime(1981, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "47546", "Federico", "Villescaz", 12, "51666632", 3, 1, 2, 500m, 2020 },
                    { 50, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2638), new DateTime(1981, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "47546", "Federico", "Villescaz", 12, "51666632", 2, 1, 2, 500m, 2020 },
                    { 49, 5000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2638), new DateTime(1981, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "47546", "Federico", "Villescaz", 12, "51666632", 1, 1, 2, 500m, 2020 },
                    { 48, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2361), new DateTime(1995, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "35262", "Gregory", "Canak", 15, "27456179", 6, 1, 2, 350m, 2020 },
                    { 47, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2361), new DateTime(1995, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "35262", "Gregory", "Canak", 15, "27456179", 5, 1, 2, 350m, 2020 },
                    { 46, 3500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2361), new DateTime(1995, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "35262", "Gregory", "Canak", 15, "27456179", 4, 1, 2, 350m, 2020 },
                    { 62, 3000m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(2865), new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "6052", "Earl", "Sansalone", 13, "44327209", 2, 2, 2, 300m, 2020 },
                    { 102, 2500m, new DateTime(2021, 4, 29, 22, 12, 0, 413, DateTimeKind.Local).AddTicks(3548), new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "58030", "Alfonzo", "Treece", 17, "78891667", 6, 2, 1, 250m, 2020 }
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
            var sp = @"CREATE FUNCTION [dbo].[Quantity_Of_Employee_By_Name]
            (	                            
	            @FirstName varchar(150),
	            @SureName varchar(150)
            )
            RETURNS int
            AS
            BEGIN
	                           
	            DECLARE @result int
	                          
	            SELECT @result = count(*)
	            from  [dbo].[Employee]
	            where [dbo].[Employee].[EmployeeName] = @FirstName and [dbo].[Employee].[EmployeeSurname] = @SureName

	            RETURN @result

            END 
            GO
            /****** Object:  UserDefinedFunction [dbo].[Quantity_Of_Salary_By_Period]    Script Date: 4/29/2021 9:08:23 PM ******/
            SET ANSI_NULLS ON
            GO
            SET QUOTED_IDENTIFIER ON
            GO
            CREATE FUNCTION [dbo].[Quantity_Of_Salary_By_Period]
                        (
	                        @EmployeeCode nvarchar(10),
	                        @Month int,
	                        @Year int
                        )
                        RETURNS int
                        AS
                        BEGIN
	                           
	                        DECLARE @result int

	                          
	                        SELECT @result = count(*)
	                        from  [dbo].[Employee]
	                        where [EmployeeCode]=@EmployeeCode and [Month]= @Month and [Year]= @Year

	                          
	                        RETURN @result

                        ENd
            GO
            /****** Object:  StoredProcedure [dbo].[Sp_Get_Last_Employee_Salary]    Script Date: 4/29/2021 9:08:23 PM ******/
            SET ANSI_NULLS ON
            GO
            SET QUOTED_IDENTIFIER ON
            GO
            CREATE PROCEDURE [dbo].[Sp_Get_Last_Employee_Salary]
	            @EmployeeCode nvarchar(10)
            AS
             BEGIN
	            IF OBJECT_ID (N'#Salaries', N'U') IS NOT NULL 
	            drop table #Salaries

	            select top(3)*
	            into #Salaries
	            from employee
	            where employeecode=@employeecode
	            order by month desc


	            select a.basesalary/3 as Bono, a.*
	            from #Salaries as a
	            where a.employeecode=@employeecode
				order by a.month
            END 
        
            GO";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
