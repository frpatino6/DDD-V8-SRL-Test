using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class addrelationshipfromfluentapi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Office_OfficeId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_OfficeId",
                table: "Employee");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 2, 1, 29, 36, 377, DateTimeKind.Local).AddTicks(178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 29, 22, 14, 0, 249, DateTimeKind.Local).AddTicks(1875));

            

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Office_PositionId",
                table: "Employee",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Office_PositionId",
                table: "Employee");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 29, 22, 14, 0, 249, DateTimeKind.Local).AddTicks(1875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 2, 1, 29, 36, 377, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 244, DateTimeKind.Local).AddTicks(5969), new DateTime(1974, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "5028", "Alejandro", "Mooneyhan", 10, "40291308", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 244, DateTimeKind.Local).AddTicks(5969), new DateTime(1974, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "5028", "Alejandro", "Mooneyhan", 10, "40291308", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 244, DateTimeKind.Local).AddTicks(5969), new DateTime(1974, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "5028", "Alejandro", "Mooneyhan", 10, "40291308", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 244, DateTimeKind.Local).AddTicks(5969), new DateTime(1974, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "5028", "Alejandro", "Mooneyhan", 10, "40291308", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 244, DateTimeKind.Local).AddTicks(5969), new DateTime(1974, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "5028", "Alejandro", "Mooneyhan", 10, "40291308", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 244, DateTimeKind.Local).AddTicks(5969), new DateTime(1974, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "5028", "Alejandro", "Mooneyhan", 10, "40291308", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3186), new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "81545", "Seymour", "An", 11, "85208531", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3186), new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "81545", "Seymour", "An", 11, "85208531", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3186), new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "81545", "Seymour", "An", 11, "85208531", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3186), new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "81545", "Seymour", "An", 11, "85208531", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3186), new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "81545", "Seymour", "An", 11, "85208531", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3186), new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "81545", "Seymour", "An", 11, "85208531", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3299), new DateTime(1969, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "64513", "Angelo", "Tudor", 13, "85454386", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3299), new DateTime(1969, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "64513", "Angelo", "Tudor", 13, "85454386", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3299), new DateTime(1969, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "64513", "Angelo", "Tudor", 13, "85454386", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3299), new DateTime(1969, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "64513", "Angelo", "Tudor", 13, "85454386", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3299), new DateTime(1969, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "64513", "Angelo", "Tudor", 13, "85454386", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3299), new DateTime(1969, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "64513", "Angelo", "Tudor", 13, "85454386", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3427), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40896", "Denver", "Kaspari", 15, "72945249", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3427), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40896", "Denver", "Kaspari", 15, "72945249", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3427), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40896", "Denver", "Kaspari", 15, "72945249", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3427), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40896", "Denver", "Kaspari", 15, "72945249", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3427), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40896", "Denver", "Kaspari", 15, "72945249", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3427), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40896", "Denver", "Kaspari", 15, "72945249", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3525), new DateTime(1972, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "24037", "Jacinto", "Bolka", 15, "38477798", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3525), new DateTime(1972, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "24037", "Jacinto", "Bolka", 15, "38477798", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3525), new DateTime(1972, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "24037", "Jacinto", "Bolka", 15, "38477798", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3525), new DateTime(1972, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "24037", "Jacinto", "Bolka", 15, "38477798", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3525), new DateTime(1972, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "24037", "Jacinto", "Bolka", 15, "38477798", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3525), new DateTime(1972, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "24037", "Jacinto", "Bolka", 15, "38477798", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3674), new DateTime(1974, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "67500", "Porfirio", "Vissman", 6, "70059412", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3674), new DateTime(1974, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "67500", "Porfirio", "Vissman", 6, "70059412", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3674), new DateTime(1974, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "67500", "Porfirio", "Vissman", 6, "70059412", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3674), new DateTime(1974, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "67500", "Porfirio", "Vissman", 6, "70059412", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3674), new DateTime(1974, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "67500", "Porfirio", "Vissman", 6, "70059412", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3674), new DateTime(1974, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "67500", "Porfirio", "Vissman", 6, "70059412", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3786), new DateTime(1978, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "94038", "Carmelo", "Vadnais", 8, "16214084", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3786), new DateTime(1978, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "94038", "Carmelo", "Vadnais", 8, "16214084", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3786), new DateTime(1978, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "94038", "Carmelo", "Vadnais", 8, "16214084", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3786), new DateTime(1978, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "94038", "Carmelo", "Vadnais", 8, "16214084", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3786), new DateTime(1978, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "94038", "Carmelo", "Vadnais", 8, "16214084", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3786), new DateTime(1978, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "94038", "Carmelo", "Vadnais", 8, "16214084", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3945), new DateTime(1964, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "6485", "Darrel", "Ciardullo", 14, "12371973", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3945), new DateTime(1964, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "6485", "Darrel", "Ciardullo", 14, "12371973", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3945), new DateTime(1964, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "6485", "Darrel", "Ciardullo", 14, "12371973", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3945), new DateTime(1964, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "6485", "Darrel", "Ciardullo", 14, "12371973", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3945), new DateTime(1964, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "6485", "Darrel", "Ciardullo", 14, "12371973", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(3945), new DateTime(1964, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "6485", "Darrel", "Ciardullo", 14, "12371973", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4038), new DateTime(1961, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "73876", "Hollis", "Becera", 6, "66241350", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4038), new DateTime(1961, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "73876", "Hollis", "Becera", 6, "66241350", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4038), new DateTime(1961, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "73876", "Hollis", "Becera", 6, "66241350", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4038), new DateTime(1961, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "73876", "Hollis", "Becera", 6, "66241350", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4038), new DateTime(1961, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "73876", "Hollis", "Becera", 6, "66241350", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4038), new DateTime(1961, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "73876", "Hollis", "Becera", 6, "66241350", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4161), new DateTime(1972, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "25228", "Earl", "Anklam", 14, "97651157", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4161), new DateTime(1972, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "25228", "Earl", "Anklam", 14, "97651157", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4161), new DateTime(1972, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "25228", "Earl", "Anklam", 14, "97651157", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4161), new DateTime(1972, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "25228", "Earl", "Anklam", 14, "97651157", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4161), new DateTime(1972, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "25228", "Earl", "Anklam", 14, "97651157", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4161), new DateTime(1972, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "25228", "Earl", "Anklam", 14, "97651157", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4254), new DateTime(1988, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36213", "Bertram", "Gillum", "58575840", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4254), new DateTime(1988, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36213", "Bertram", "Gillum", "58575840", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4254), new DateTime(1988, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36213", "Bertram", "Gillum", "58575840", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4254), new DateTime(1988, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36213", "Bertram", "Gillum", "58575840", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4254), new DateTime(1988, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36213", "Bertram", "Gillum", "58575840", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4254), new DateTime(1988, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36213", "Bertram", "Gillum", "58575840", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4382), new DateTime(1963, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "14579", "Shaun", "Williver", 11, "56852819", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4382), new DateTime(1963, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "14579", "Shaun", "Williver", 11, "56852819", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4382), new DateTime(1963, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "14579", "Shaun", "Williver", 11, "56852819", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4382), new DateTime(1963, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "14579", "Shaun", "Williver", 11, "56852819", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4382), new DateTime(1963, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "14579", "Shaun", "Williver", 11, "56852819", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4382), new DateTime(1963, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "14579", "Shaun", "Williver", 11, "56852819", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4475), new DateTime(1982, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "43201", "Frances", "Kruss", 13, "45434865", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4475), new DateTime(1982, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "43201", "Frances", "Kruss", 13, "45434865", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4475), new DateTime(1982, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "43201", "Frances", "Kruss", 13, "45434865", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4475), new DateTime(1982, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "43201", "Frances", "Kruss", 13, "45434865", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4475), new DateTime(1982, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "43201", "Frances", "Kruss", 13, "45434865", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4475), new DateTime(1982, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "43201", "Frances", "Kruss", 13, "45434865", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4598), new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "42451", "Ahmed", "Kipps", 17, "73692175", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4598), new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "42451", "Ahmed", "Kipps", 17, "73692175", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4598), new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "42451", "Ahmed", "Kipps", 17, "73692175", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4598), new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "42451", "Ahmed", "Kipps", 17, "73692175", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4598), new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "42451", "Ahmed", "Kipps", 17, "73692175", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4598), new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "42451", "Ahmed", "Kipps", 17, "73692175", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4691), new DateTime(1976, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "85732", "Jamey", "Mcclean", 9, "14460311", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4691), new DateTime(1976, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "85732", "Jamey", "Mcclean", 9, "14460311", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4691), new DateTime(1976, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "85732", "Jamey", "Mcclean", 9, "14460311", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4691), new DateTime(1976, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "85732", "Jamey", "Mcclean", 9, "14460311", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4691), new DateTime(1976, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "85732", "Jamey", "Mcclean", 9, "14460311", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4691), new DateTime(1976, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "85732", "Jamey", "Mcclean", 9, "14460311", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4830), new DateTime(1988, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "82046", "Vince", "Arwood", 17, "89353976", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4830), new DateTime(1988, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "82046", "Vince", "Arwood", 17, "89353976", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4830), new DateTime(1988, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "82046", "Vince", "Arwood", 17, "89353976", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4830), new DateTime(1988, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "82046", "Vince", "Arwood", 17, "89353976", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4830), new DateTime(1988, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "82046", "Vince", "Arwood", 17, "89353976", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4830), new DateTime(1988, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "82046", "Vince", "Arwood", 17, "89353976", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4922), new DateTime(1989, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "90634", "Tory", "La", 12, "50048189", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4922), new DateTime(1989, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "90634", "Tory", "La", 12, "50048189", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4922), new DateTime(1989, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "90634", "Tory", "La", 12, "50048189", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4922), new DateTime(1989, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "90634", "Tory", "La", 12, "50048189", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4922), new DateTime(1989, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "90634", "Tory", "La", 12, "50048189", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 22, 14, 0, 246, DateTimeKind.Local).AddTicks(4922), new DateTime(1989, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "90634", "Tory", "La", 12, "50048189", 2, 200m });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_OfficeId",
                table: "Employee",
                column: "OfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Office_OfficeId",
                table: "Employee",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
