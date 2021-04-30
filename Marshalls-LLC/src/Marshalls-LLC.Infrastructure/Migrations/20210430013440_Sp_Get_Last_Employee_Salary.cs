using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class Sp_Get_Last_Employee_Salary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 29, 20, 34, 40, 298, DateTimeKind.Local).AddTicks(2073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 29, 15, 46, 33, 468, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "13596", "Owen", "Zarillo", 11, "43898990", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "13596", "Owen", "Zarillo", 11, "43898990", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "13596", "Owen", "Zarillo", 11, "43898990", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "13596", "Owen", "Zarillo", 11, "43898990", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "13596", "Owen", "Zarillo", 11, "43898990", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "13596", "Owen", "Zarillo", 11, "43898990", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3749), new DateTime(1968, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "92164", "Brent", "Crocket", 7, "9351102", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3749), new DateTime(1968, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "92164", "Brent", "Crocket", 7, "9351102", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3749), new DateTime(1968, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "92164", "Brent", "Crocket", 7, "9351102", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3749), new DateTime(1968, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "92164", "Brent", "Crocket", 7, "9351102", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3749), new DateTime(1968, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "92164", "Brent", "Crocket", 7, "9351102", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3749), new DateTime(1968, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "92164", "Brent", "Crocket", 7, "9351102", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3898), new DateTime(1973, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "17136", "Shad", "Biby", 6, "15372715", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3898), new DateTime(1973, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "17136", "Shad", "Biby", 6, "15372715", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3898), new DateTime(1973, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "17136", "Shad", "Biby", 6, "15372715", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3898), new DateTime(1973, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "17136", "Shad", "Biby", 6, "15372715", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3898), new DateTime(1973, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "17136", "Shad", "Biby", 6, "15372715", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3898), new DateTime(1973, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "17136", "Shad", "Biby", 6, "15372715", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", 6, "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", 6, "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", 6, "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", 6, "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", 6, "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", 6, "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4135), new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "9751", "Octavio", "Kresky", 12, "12972852", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4135), new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "9751", "Octavio", "Kresky", 12, "12972852", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4135), new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "9751", "Octavio", "Kresky", 12, "12972852", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4135), new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "9751", "Octavio", "Kresky", 12, "12972852", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4135), new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "9751", "Octavio", "Kresky", 12, "12972852", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4135), new DateTime(1990, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "9751", "Octavio", "Kresky", 12, "12972852", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4674), new DateTime(1998, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "10260", "Elisha", "Heenan", 6, "74851561", 1, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4674), new DateTime(1998, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "10260", "Elisha", "Heenan", 6, "74851561", 1, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4674), new DateTime(1998, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "10260", "Elisha", "Heenan", 6, "74851561", 1, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4674), new DateTime(1998, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "10260", "Elisha", "Heenan", 6, "74851561", 1, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4674), new DateTime(1998, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "10260", "Elisha", "Heenan", 6, "74851561", 1, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4674), new DateTime(1998, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "10260", "Elisha", "Heenan", 6, "74851561", 1, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "84889", "Kareem", "Asif", 12, "87158345" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "84889", "Kareem", "Asif", 12, "87158345" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "84889", "Kareem", "Asif", 12, "87158345" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "84889", "Kareem", "Asif", 12, "87158345" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "84889", "Kareem", "Asif", 12, "87158345" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "84889", "Kareem", "Asif", 12, "87158345" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 350m });

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
	                        @Id int,
	                        @Month int,
	                        @Year int
                        )
                        RETURNS int
                        AS
                        BEGIN
	                           
	                        DECLARE @result int

	                          
	                        SELECT @result = count(*)
	                        from  [dbo].[Employee]
	                        where [Id]=@Id and [Month]= @Month and [Year]= @Year

	                          
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


	            select a.employeecode,a.basesalary, a.basesalary/3 as bono
	            from #Salaries as a
	            where a.employeecode=@employeecode
            END 
        
            GO";

             migrationBuilder.Sql(sp);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 29, 15, 46, 33, 468, DateTimeKind.Local).AddTicks(5732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 29, 20, 34, 40, 298, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "32505", "Norris", "Millian", 16, "8444133", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "32505", "Norris", "Millian", 16, "8444133", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "32505", "Norris", "Millian", 16, "8444133", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "32505", "Norris", "Millian", 16, "8444133", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "32505", "Norris", "Millian", 16, "8444133", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "32505", "Norris", "Millian", 16, "8444133", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "57612", "Erasmo", "Rademaker", 12, "63553589", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "57612", "Erasmo", "Rademaker", 12, "63553589", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "57612", "Erasmo", "Rademaker", 12, "63553589", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "57612", "Erasmo", "Rademaker", 12, "63553589", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "57612", "Erasmo", "Rademaker", 12, "63553589", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "57612", "Erasmo", "Rademaker", 12, "63553589", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 2, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 2, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 2, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 2, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 2, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 2, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", 11, "76517387", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", 11, "76517387", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", 11, "76517387", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", 11, "76517387", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", 11, "76517387", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", 11, "76517387", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69295", "Darryl", "Lipinsky", 8, "33564962", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69295", "Darryl", "Lipinsky", 8, "33564962", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69295", "Darryl", "Lipinsky", 8, "33564962", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69295", "Darryl", "Lipinsky", 8, "33564962", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69295", "Darryl", "Lipinsky", 8, "33564962", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69295", "Darryl", "Lipinsky", 8, "33564962", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "62163", "Rusty", "Digges", 15, "45995417", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "62163", "Rusty", "Digges", 15, "45995417", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "62163", "Rusty", "Digges", 15, "45995417", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "62163", "Rusty", "Digges", 15, "45995417", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "62163", "Rusty", "Digges", 15, "45995417", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "62163", "Rusty", "Digges", 15, "45995417", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", "87556813", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", "87556813", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", "87556813", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", "87556813", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", "87556813", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", "87556813", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2806), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "3452", "Keneth", "Lahue", 7, "66238512", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2806), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "3452", "Keneth", "Lahue", 7, "66238512", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2806), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "3452", "Keneth", "Lahue", 7, "66238512", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2806), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "3452", "Keneth", "Lahue", 7, "66238512", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2806), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "3452", "Keneth", "Lahue", 7, "66238512", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2806), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "3452", "Keneth", "Lahue", 7, "66238512", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "63889", "Hyman", "Taniguchi", 17, "7559023" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "63889", "Hyman", "Taniguchi", 17, "7559023" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "63889", "Hyman", "Taniguchi", 17, "7559023" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "63889", "Hyman", "Taniguchi", 17, "7559023" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "63889", "Hyman", "Taniguchi", 17, "7559023" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "63889", "Hyman", "Taniguchi", 17, "7559023" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "52915", "Robbie", "Sollors", 17, "71330309", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "52915", "Robbie", "Sollors", 17, "71330309", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "52915", "Robbie", "Sollors", 17, "71330309", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "52915", "Robbie", "Sollors", 17, "71330309", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "52915", "Robbie", "Sollors", 17, "71330309", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "52915", "Robbie", "Sollors", 17, "71330309", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69950", "Pete", "Verhey", 14, "68014801", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69950", "Pete", "Verhey", 14, "68014801", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69950", "Pete", "Verhey", 14, "68014801", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69950", "Pete", "Verhey", 14, "68014801", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69950", "Pete", "Verhey", 14, "68014801", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69950", "Pete", "Verhey", 14, "68014801", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 250m });
        }
    }
}
