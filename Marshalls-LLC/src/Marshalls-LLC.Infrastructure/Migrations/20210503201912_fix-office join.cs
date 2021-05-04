using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class fixofficejoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 3, 15, 19, 11, 211, DateTimeKind.Local).AddTicks(23),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 3, 15, 15, 21, 177, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 208, DateTimeKind.Local).AddTicks(248), new DateTime(1967, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17965", "Clay", "Botras", 14, "73976502", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 208, DateTimeKind.Local).AddTicks(248), new DateTime(1967, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17965", "Clay", "Botras", 14, "73976502", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 208, DateTimeKind.Local).AddTicks(248), new DateTime(1967, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17965", "Clay", "Botras", 14, "73976502", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 208, DateTimeKind.Local).AddTicks(248), new DateTime(1967, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17965", "Clay", "Botras", 14, "73976502", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 208, DateTimeKind.Local).AddTicks(248), new DateTime(1967, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17965", "Clay", "Botras", 14, "73976502", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 208, DateTimeKind.Local).AddTicks(248), new DateTime(1967, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17965", "Clay", "Botras", 14, "73976502", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1588), new DateTime(1966, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "52628", "Denis", "Praska", 12, "63765698", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1588), new DateTime(1966, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "52628", "Denis", "Praska", 12, "63765698", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1588), new DateTime(1966, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "52628", "Denis", "Praska", 12, "63765698", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1588), new DateTime(1966, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "52628", "Denis", "Praska", 12, "63765698", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1588), new DateTime(1966, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "52628", "Denis", "Praska", 12, "63765698", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1588), new DateTime(1966, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "52628", "Denis", "Praska", 12, "63765698", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1809), new DateTime(1997, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "43883", "Donnie", "Rabe", 16, "11138061", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1809), new DateTime(1997, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "43883", "Donnie", "Rabe", 16, "11138061", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1809), new DateTime(1997, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "43883", "Donnie", "Rabe", 16, "11138061", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1809), new DateTime(1997, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "43883", "Donnie", "Rabe", 16, "11138061", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1809), new DateTime(1997, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "43883", "Donnie", "Rabe", 16, "11138061", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1809), new DateTime(1997, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "43883", "Donnie", "Rabe", 16, "11138061", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1942), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "13937", "Lane", "Mende", 8, "20361909", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1942), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "13937", "Lane", "Mende", 8, "20361909", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1942), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "13937", "Lane", "Mende", 8, "20361909", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1942), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "13937", "Lane", "Mende", 8, "20361909", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1942), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "13937", "Lane", "Mende", 8, "20361909", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(1942), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "13937", "Lane", "Mende", 8, "20361909", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2138), new DateTime(1971, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "99675", "Leroy", "Simson", "18194796", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2138), new DateTime(1971, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "99675", "Leroy", "Simson", "18194796", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2138), new DateTime(1971, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "99675", "Leroy", "Simson", "18194796", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2138), new DateTime(1971, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "99675", "Leroy", "Simson", "18194796", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2138), new DateTime(1971, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "99675", "Leroy", "Simson", "18194796", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2138), new DateTime(1971, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "99675", "Leroy", "Simson", "18194796", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2266), new DateTime(1968, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "46343", "Bryce", "Shotts", 13, "31831377", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2266), new DateTime(1968, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "46343", "Bryce", "Shotts", 13, "31831377", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2266), new DateTime(1968, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "46343", "Bryce", "Shotts", 13, "31831377", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2266), new DateTime(1968, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "46343", "Bryce", "Shotts", 13, "31831377", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2266), new DateTime(1968, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "46343", "Bryce", "Shotts", 13, "31831377", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2266), new DateTime(1968, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "46343", "Bryce", "Shotts", 13, "31831377", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2462), new DateTime(1975, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "5551", "Willie", "Debnar", 10, "83545313", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2462), new DateTime(1975, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "5551", "Willie", "Debnar", 10, "83545313", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2462), new DateTime(1975, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "5551", "Willie", "Debnar", 10, "83545313", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2462), new DateTime(1975, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "5551", "Willie", "Debnar", 10, "83545313", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2462), new DateTime(1975, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "5551", "Willie", "Debnar", 10, "83545313", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2462), new DateTime(1975, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "5551", "Willie", "Debnar", 10, "83545313", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2590), new DateTime(1992, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "6154", "Tommy", "Barrilleaux", 10, "59195440", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2590), new DateTime(1992, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "6154", "Tommy", "Barrilleaux", 10, "59195440", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2590), new DateTime(1992, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "6154", "Tommy", "Barrilleaux", 10, "59195440", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2590), new DateTime(1992, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "6154", "Tommy", "Barrilleaux", 10, "59195440", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2590), new DateTime(1992, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "6154", "Tommy", "Barrilleaux", 10, "59195440", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2590), new DateTime(1992, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "6154", "Tommy", "Barrilleaux", 10, "59195440", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2821), new DateTime(1966, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "61645", "Lucius", "Bibles", 15, "4605850", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2821), new DateTime(1966, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "61645", "Lucius", "Bibles", 15, "4605850", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2821), new DateTime(1966, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "61645", "Lucius", "Bibles", 15, "4605850", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2821), new DateTime(1966, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "61645", "Lucius", "Bibles", 15, "4605850", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2821), new DateTime(1966, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "61645", "Lucius", "Bibles", 15, "4605850", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2821), new DateTime(1966, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "61645", "Lucius", "Bibles", 15, "4605850", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2981), new DateTime(1985, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "59573", "Ronny", "Foulk", 9, "45983363", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2981), new DateTime(1985, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "59573", "Ronny", "Foulk", 9, "45983363", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2981), new DateTime(1985, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "59573", "Ronny", "Foulk", 9, "45983363", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2981), new DateTime(1985, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "59573", "Ronny", "Foulk", 9, "45983363", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2981), new DateTime(1985, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "59573", "Ronny", "Foulk", 9, "45983363", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(2981), new DateTime(1985, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "59573", "Ronny", "Foulk", 9, "45983363", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3207), new DateTime(1971, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "89300", "Jackson", "Wafford", 8, "9146194", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3207), new DateTime(1971, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "89300", "Jackson", "Wafford", 8, "9146194", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3207), new DateTime(1971, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "89300", "Jackson", "Wafford", 8, "9146194", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3207), new DateTime(1971, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "89300", "Jackson", "Wafford", 8, "9146194", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3207), new DateTime(1971, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "89300", "Jackson", "Wafford", 8, "9146194", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3207), new DateTime(1971, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "89300", "Jackson", "Wafford", 8, "9146194", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3495), new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20112", "Douglass", "Earnhart", 7, "66825620", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3495), new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20112", "Douglass", "Earnhart", 7, "66825620", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3495), new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20112", "Douglass", "Earnhart", 7, "66825620", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3495), new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20112", "Douglass", "Earnhart", 7, "66825620", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3495), new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20112", "Douglass", "Earnhart", 7, "66825620", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3495), new DateTime(1997, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20112", "Douglass", "Earnhart", 7, "66825620", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3628), new DateTime(1981, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72873", "Chi", "Cardinal", "8037474", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3628), new DateTime(1981, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72873", "Chi", "Cardinal", "8037474", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3628), new DateTime(1981, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72873", "Chi", "Cardinal", "8037474", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3628), new DateTime(1981, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72873", "Chi", "Cardinal", "8037474", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3628), new DateTime(1981, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72873", "Chi", "Cardinal", "8037474", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3628), new DateTime(1981, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72873", "Chi", "Cardinal", "8037474", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3855), new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "42012", "Tod", "Paysinger", 14, "58322904", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3855), new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "42012", "Tod", "Paysinger", 14, "58322904", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3855), new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "42012", "Tod", "Paysinger", 14, "58322904", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3855), new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "42012", "Tod", "Paysinger", 14, "58322904", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3855), new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "42012", "Tod", "Paysinger", 14, "58322904", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3855), new DateTime(2000, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "42012", "Tod", "Paysinger", 14, "58322904", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3993), new DateTime(1982, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "46457", "Greg", "Annonio", 15, "27923997", 1, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3993), new DateTime(1982, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "46457", "Greg", "Annonio", 15, "27923997", 1, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3993), new DateTime(1982, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "46457", "Greg", "Annonio", 15, "27923997", 1, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3993), new DateTime(1982, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "46457", "Greg", "Annonio", 15, "27923997", 1, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3993), new DateTime(1982, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "46457", "Greg", "Annonio", 15, "27923997", 1, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(3993), new DateTime(1982, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "46457", "Greg", "Annonio", 15, "27923997", 1, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4179), new DateTime(1968, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "90505", "Kyle", "Younge", 10, "18248885", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4179), new DateTime(1968, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "90505", "Kyle", "Younge", 10, "18248885", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4179), new DateTime(1968, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "90505", "Kyle", "Younge", 10, "18248885", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4179), new DateTime(1968, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "90505", "Kyle", "Younge", 10, "18248885", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4179), new DateTime(1968, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "90505", "Kyle", "Younge", 10, "18248885", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4179), new DateTime(1968, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "90505", "Kyle", "Younge", 10, "18248885", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4312), new DateTime(1987, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "53458", "Mervin", "Bradfield", 10, "94629384", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4312), new DateTime(1987, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "53458", "Mervin", "Bradfield", 10, "94629384", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4312), new DateTime(1987, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "53458", "Mervin", "Bradfield", 10, "94629384", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4312), new DateTime(1987, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "53458", "Mervin", "Bradfield", 10, "94629384", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4312), new DateTime(1987, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "53458", "Mervin", "Bradfield", 10, "94629384", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 19, 11, 210, DateTimeKind.Local).AddTicks(4312), new DateTime(1987, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "53458", "Mervin", "Bradfield", 10, "94629384", 250m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 5, 3, 15, 15, 21, 177, DateTimeKind.Local).AddTicks(4067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 5, 3, 15, 19, 11, 211, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 173, DateTimeKind.Local).AddTicks(6499), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "76366", "Leandro", "Carnegie", 9, "10104203", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 173, DateTimeKind.Local).AddTicks(6499), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "76366", "Leandro", "Carnegie", 9, "10104203", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 173, DateTimeKind.Local).AddTicks(6499), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "76366", "Leandro", "Carnegie", 9, "10104203", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 173, DateTimeKind.Local).AddTicks(6499), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "76366", "Leandro", "Carnegie", 9, "10104203", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 173, DateTimeKind.Local).AddTicks(6499), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "76366", "Leandro", "Carnegie", 9, "10104203", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 173, DateTimeKind.Local).AddTicks(6499), new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "76366", "Leandro", "Carnegie", 9, "10104203", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3683), new DateTime(1991, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "81622", "Lane", "Khay", 11, "29779816", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3683), new DateTime(1991, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "81622", "Lane", "Khay", 11, "29779816", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3683), new DateTime(1991, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "81622", "Lane", "Khay", 11, "29779816", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3683), new DateTime(1991, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "81622", "Lane", "Khay", 11, "29779816", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3683), new DateTime(1991, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "81622", "Lane", "Khay", 11, "29779816", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3683), new DateTime(1991, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "81622", "Lane", "Khay", 11, "29779816", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3945), new DateTime(1998, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "79395", "Wilton", "Alcoser", 14, "18725804", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3945), new DateTime(1998, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "79395", "Wilton", "Alcoser", 14, "18725804", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3945), new DateTime(1998, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "79395", "Wilton", "Alcoser", 14, "18725804", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3945), new DateTime(1998, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "79395", "Wilton", "Alcoser", 14, "18725804", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3945), new DateTime(1998, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "79395", "Wilton", "Alcoser", 14, "18725804", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(3945), new DateTime(1998, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "79395", "Wilton", "Alcoser", 14, "18725804", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4089), new DateTime(2000, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "76465", "Weldon", "Pults", 10, "74382225", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4089), new DateTime(2000, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "76465", "Weldon", "Pults", 10, "74382225", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4089), new DateTime(2000, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "76465", "Weldon", "Pults", 10, "74382225", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4089), new DateTime(2000, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "76465", "Weldon", "Pults", 10, "74382225", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4089), new DateTime(2000, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "76465", "Weldon", "Pults", 10, "74382225", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4089), new DateTime(2000, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "76465", "Weldon", "Pults", 10, "74382225", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4279), new DateTime(1975, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "34318", "Connie", "Jabour", "44573873", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4279), new DateTime(1975, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "34318", "Connie", "Jabour", "44573873", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4279), new DateTime(1975, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "34318", "Connie", "Jabour", "44573873", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4279), new DateTime(1975, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "34318", "Connie", "Jabour", "44573873", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4279), new DateTime(1975, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "34318", "Connie", "Jabour", "44573873", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4279), new DateTime(1975, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "34318", "Connie", "Jabour", "44573873", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4423), new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "63168", "Alfonso", "Charles", 12, "22026139", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4423), new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "63168", "Alfonso", "Charles", 12, "22026139", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4423), new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "63168", "Alfonso", "Charles", 12, "22026139", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4423), new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "63168", "Alfonso", "Charles", 12, "22026139", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4423), new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "63168", "Alfonso", "Charles", 12, "22026139", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4423), new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "63168", "Alfonso", "Charles", 12, "22026139", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4613), new DateTime(1996, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "82041", "Sid", "Ringdahl", 16, "8652783", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4613), new DateTime(1996, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "82041", "Sid", "Ringdahl", 16, "8652783", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4613), new DateTime(1996, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "82041", "Sid", "Ringdahl", 16, "8652783", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4613), new DateTime(1996, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "82041", "Sid", "Ringdahl", 16, "8652783", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4613), new DateTime(1996, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "82041", "Sid", "Ringdahl", 16, "8652783", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4613), new DateTime(1996, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "82041", "Sid", "Ringdahl", 16, "8652783", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4752), new DateTime(1978, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13950", "Armand", "Wesche", 6, "56911063", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4752), new DateTime(1978, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13950", "Armand", "Wesche", 6, "56911063", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4752), new DateTime(1978, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13950", "Armand", "Wesche", 6, "56911063", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4752), new DateTime(1978, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13950", "Armand", "Wesche", 6, "56911063", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4752), new DateTime(1978, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13950", "Armand", "Wesche", 6, "56911063", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(4752), new DateTime(1978, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13950", "Armand", "Wesche", 6, "56911063", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5040), new DateTime(1980, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "49990", "Tobias", "Volpi", 10, "83147436", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5040), new DateTime(1980, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "49990", "Tobias", "Volpi", 10, "83147436", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5040), new DateTime(1980, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "49990", "Tobias", "Volpi", 10, "83147436", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5040), new DateTime(1980, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "49990", "Tobias", "Volpi", 10, "83147436", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5040), new DateTime(1980, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "49990", "Tobias", "Volpi", 10, "83147436", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5040), new DateTime(1980, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "49990", "Tobias", "Volpi", 10, "83147436", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5184), new DateTime(1996, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "21589", "Billie", "Catt", 12, "72115069", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5184), new DateTime(1996, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "21589", "Billie", "Catt", 12, "72115069", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5184), new DateTime(1996, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "21589", "Billie", "Catt", 12, "72115069", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5184), new DateTime(1996, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "21589", "Billie", "Catt", 12, "72115069", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5184), new DateTime(1996, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "21589", "Billie", "Catt", 12, "72115069", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5184), new DateTime(1996, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "21589", "Billie", "Catt", 12, "72115069", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5400), new DateTime(1991, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "80380", "Omer", "Petrakis", 17, "52496447", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5400), new DateTime(1991, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "80380", "Omer", "Petrakis", 17, "52496447", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5400), new DateTime(1991, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "80380", "Omer", "Petrakis", 17, "52496447", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5400), new DateTime(1991, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "80380", "Omer", "Petrakis", 17, "52496447", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5400), new DateTime(1991, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "80380", "Omer", "Petrakis", 17, "52496447", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5400), new DateTime(1991, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "80380", "Omer", "Petrakis", 17, "52496447", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5605), new DateTime(1985, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "95225", "Gustavo", "Bannister", 16, "66828763", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5605), new DateTime(1985, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "95225", "Gustavo", "Bannister", 16, "66828763", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5605), new DateTime(1985, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "95225", "Gustavo", "Bannister", 16, "66828763", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5605), new DateTime(1985, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "95225", "Gustavo", "Bannister", 16, "66828763", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5605), new DateTime(1985, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "95225", "Gustavo", "Bannister", 16, "66828763", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5605), new DateTime(1985, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "95225", "Gustavo", "Bannister", 16, "66828763", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5754), new DateTime(1973, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "98777", "Errol", "Laffitte", "45239849", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5754), new DateTime(1973, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "98777", "Errol", "Laffitte", "45239849", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5754), new DateTime(1973, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "98777", "Errol", "Laffitte", "45239849", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5754), new DateTime(1973, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "98777", "Errol", "Laffitte", "45239849", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5754), new DateTime(1973, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "98777", "Errol", "Laffitte", "45239849", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5754), new DateTime(1973, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "98777", "Errol", "Laffitte", "45239849", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5893), new DateTime(1997, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "78814", "Clayton", "Schreier", 12, "14587152", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5893), new DateTime(1997, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "78814", "Clayton", "Schreier", 12, "14587152", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5893), new DateTime(1997, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "78814", "Clayton", "Schreier", 12, "14587152", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5893), new DateTime(1997, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "78814", "Clayton", "Schreier", 12, "14587152", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5893), new DateTime(1997, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "78814", "Clayton", "Schreier", 12, "14587152", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(5893), new DateTime(1997, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "78814", "Clayton", "Schreier", 12, "14587152", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6145), new DateTime(1984, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "11173", "Federico", "Zych", 13, "57266103", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6145), new DateTime(1984, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "11173", "Federico", "Zych", 13, "57266103", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6145), new DateTime(1984, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "11173", "Federico", "Zych", 13, "57266103", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6145), new DateTime(1984, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "11173", "Federico", "Zych", 13, "57266103", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6145), new DateTime(1984, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "11173", "Federico", "Zych", 13, "57266103", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6145), new DateTime(1984, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "11173", "Federico", "Zych", 13, "57266103", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6284), new DateTime(1969, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "32703", "Stephan", "Mccain", 13, "78028696", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6284), new DateTime(1969, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "32703", "Stephan", "Mccain", 13, "78028696", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6284), new DateTime(1969, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "32703", "Stephan", "Mccain", 13, "78028696", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6284), new DateTime(1969, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "32703", "Stephan", "Mccain", 13, "78028696", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6284), new DateTime(1969, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "32703", "Stephan", "Mccain", 13, "78028696", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6284), new DateTime(1969, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "32703", "Stephan", "Mccain", 13, "78028696", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6474), new DateTime(1968, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93586", "Cole", "Crosthwaite", 9, "40180607", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6474), new DateTime(1968, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93586", "Cole", "Crosthwaite", 9, "40180607", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6474), new DateTime(1968, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93586", "Cole", "Crosthwaite", 9, "40180607", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6474), new DateTime(1968, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93586", "Cole", "Crosthwaite", 9, "40180607", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6474), new DateTime(1968, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93586", "Cole", "Crosthwaite", 9, "40180607", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 5, 3, 15, 15, 21, 176, DateTimeKind.Local).AddTicks(6474), new DateTime(1968, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93586", "Cole", "Crosthwaite", 9, "40180607", 700m });
        }
    }
}
