using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class changeemployeeseedentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2021, 4, 29, 8, 22, 15, 109, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "32505", "Norris", "Millian", 16, "8444133", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "32505", "Norris", "Millian", 16, "8444133", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "32505", "Norris", "Millian", 16, "8444133", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "32505", "Norris", "Millian", 16, "8444133", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "32505", "Norris", "Millian", 16, "8444133" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 462, DateTimeKind.Local).AddTicks(7418), new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "32505", "Norris", "Millian", 16, "8444133", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "57612", "Erasmo", "Rademaker", 12, "63553589", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "57612", "Erasmo", "Rademaker", 12, "63553589", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "57612", "Erasmo", "Rademaker", "63553589", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "57612", "Erasmo", "Rademaker", 12, "63553589", 1, 400m });

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
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1418), new DateTime(1984, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "57612", "Erasmo", "Rademaker", 12, "63553589", 2 });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "84624", "Joesph", "Sosby", 12, "63957632", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1634), new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "84624", "Joesph", "Sosby", 12, "63957632", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", "76517387", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", 11, "76517387", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", 11, "76517387", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1737), new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71959", "Jerome", "Gamberini", "76517387", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "69295", "Darryl", "Lipinsky", 8, "33564962" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "69295", "Darryl", "Lipinsky", 8, "33564962", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "69295", "Darryl", "Lipinsky", 8, "33564962" });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(1876), new DateTime(1967, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69295", "Darryl", "Lipinsky", 8, "33564962", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "62163", "Rusty", "Digges", "45995417", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "62163", "Rusty", "Digges", 15, "45995417", 1, 700m });

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
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "62163", "Rusty", "Digges", 15, "45995417", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "62163", "Rusty", "Digges", 15, "45995417", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2035), new DateTime(1977, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "62163", "Rusty", "Digges", 15, "45995417", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", "52473966", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2190), new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "12397", "Mohamed", "Liebeck", 10, "52473966", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 2, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2292), new DateTime(1966, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "19710", "Charlie", "Ellenbee", 6, "74541903", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", "6103520", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85322", "King", "Faron", 10, "6103520", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2426), new DateTime(1977, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "85322", "King", "Faron", 10, "6103520", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", 8, "87556813", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", 8, "87556813", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", 8, "87556813", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", "87556813", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", 8, "87556813", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2524), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "76378", "Dylan", "Eiken", 8, "87556813", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 2, 400m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9810", "Frederic", "Janrhett", 13, "4696206", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2709), new DateTime(1998, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "9810", "Frederic", "Janrhett", 13, "4696206", 2, 400m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2806), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "3452", "Keneth", "Lahue", 7, "66238512", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2806), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "3452", "Keneth", "Lahue", 7, "66238512", 1, 700m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2806), new DateTime(1991, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "3452", "Keneth", "Lahue", 7, "66238512", 2, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "63889", "Hyman", "Taniguchi", 17, "7559023", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "63889", "Hyman", "Taniguchi", 17, "7559023", 1, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "63889", "Hyman", "Taniguchi", 17, "7559023", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "63889", "Hyman", "Taniguchi", 17, "7559023", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "63889", "Hyman", "Taniguchi", 17, "7559023", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(2940), new DateTime(1994, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "63889", "Hyman", "Taniguchi", "7559023", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 1, 350m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "87842", "Travis", "Sumaran", 9, "28113917", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3038), new DateTime(1998, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "87842", "Travis", "Sumaran", 9, "28113917" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "52915", "Robbie", "Sollors", 17, "71330309", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "52915", "Robbie", "Sollors", 17, "71330309", 350m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "52915", "Robbie", "Sollors", 17, "71330309", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3177), new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "52915", "Robbie", "Sollors", 17, "71330309", 1 });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69950", "Pete", "Verhey", "68014801", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "69950", "Pete", "Verhey", 14, "68014801", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69950", "Pete", "Verhey", 14, "68014801", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "69950", "Pete", "Verhey", 14, "68014801", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3274), new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "69950", "Pete", "Verhey", 14, "68014801", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", "86293382", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 1, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 1, 250m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 15, 46, 33, 465, DateTimeKind.Local).AddTicks(3516), new DateTime(1960, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "24180", "Warren", "Stauble", 14, "86293382", 1, 1, 250m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 29, 8, 22, 15, 109, DateTimeKind.Local).AddTicks(8678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 29, 15, 46, 33, 468, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 104, DateTimeKind.Local).AddTicks(1711), new DateTime(1976, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "7423", "Carlton", "Jacka", 15, "67258263", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(2663), new DateTime(1978, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "7423", "Carlton", "Jacka", 10, "43399044", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3007), new DateTime(1992, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "7423", "Carlton", "Jacka", 7, "67090504", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3043), new DateTime(1973, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "7423", "Carlton", "Jacka", 11, "37794218", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3069), new DateTime(1994, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "7423", "Carlton", "Jacka", 10, "94474739" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3157), new DateTime(1980, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "7423", "Carlton", "Jacka", 12, "90819315", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3208), new DateTime(1990, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "36843", "Hank", "Bridgette", 14, "1255092", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3234), new DateTime(1963, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36843", "Hank", "Bridgette", 11, "66398051", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3259), new DateTime(1994, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "36843", "Hank", "Bridgette", "32882391", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3285), new DateTime(1976, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "36843", "Hank", "Bridgette", 13, "71110050", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3306), new DateTime(1973, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "36843", "Hank", "Bridgette", 16, "53874900", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3336), new DateTime(1999, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "36843", "Hank", "Bridgette", 6, "64252096", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3367), new DateTime(1976, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "43146", "Roberto", "Triplet", 13, "85680565", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3393), new DateTime(1974, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "43146", "Roberto", "Triplet", 16, "63664176", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3414), new DateTime(1972, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "43146", "Roberto", "Triplet", 13, "45382897", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3434), new DateTime(1991, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "43146", "Roberto", "Triplet", 13, "58271366", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3460), new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "43146", "Roberto", "Triplet", 15, "71729885", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3522), new DateTime(1992, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "43146", "Roberto", "Triplet", 15, "26316570", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3547), new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "25091", "Carlos", "Chrones", "67430546", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3573), new DateTime(1992, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "25091", "Carlos", "Chrones", 15, "21151120", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3594), new DateTime(1983, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "25091", "Carlos", "Chrones", 13, "48899140", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3614), new DateTime(1980, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "25091", "Carlos", "Chrones", 9, "7353828", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3640), new DateTime(1976, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "25091", "Carlos", "Chrones", 14, "52229870", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3660), new DateTime(1983, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "25091", "Carlos", "Chrones", "66711857", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3681), new DateTime(1978, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "95851", "Paris", "Schwall", 16, "28370041" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3707), new DateTime(1988, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "95851", "Paris", "Schwall", 16, "27734849", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3727), new DateTime(1962, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "95851", "Paris", "Schwall", 6, "30311292" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3748), new DateTime(1994, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "95851", "Paris", "Schwall", 14, "16465638", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3768), new DateTime(1968, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "95851", "Paris", "Schwall", 13, "61537045", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3830), new DateTime(1989, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "95851", "Paris", "Schwall", 17, "76259756", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3871), new DateTime(1966, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "89673", "Martin", "Ailes", "46304617", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3897), new DateTime(1982, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89673", "Martin", "Ailes", 17, "18603809", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3923), new DateTime(1978, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89673", "Martin", "Ailes", 9, "834303", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3948), new DateTime(1963, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "89673", "Martin", "Ailes", 17, "30844454", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3969), new DateTime(1980, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "89673", "Martin", "Ailes", 10, "41775287", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3995), new DateTime(1960, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "89673", "Martin", "Ailes", 16, "47400087", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4015), new DateTime(1966, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "77469", "Dirk", "Binker", 15, "35467139", 2, 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4041), new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "77469", "Dirk", "Binker", 17, "86941039", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4061), new DateTime(1961, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "77469", "Dirk", "Binker", 6, "67493640", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4082), new DateTime(1984, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "77469", "Dirk", "Binker", 13, "71540294", 2, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4144), new DateTime(1971, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "77469", "Dirk", "Binker", "20024907", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4174), new DateTime(1964, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "77469", "Dirk", "Binker", 15, "52747339", 2, 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4200), new DateTime(1979, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "13398", "Luciano", "Murphy", 9, "26551652", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4226), new DateTime(1981, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "13398", "Luciano", "Murphy", 13, "33448457", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4246), new DateTime(1993, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "13398", "Luciano", "Murphy", 10, "26884455", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4272), new DateTime(1963, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "13398", "Luciano", "Murphy", 11, "14533330", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4293), new DateTime(1987, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "13398", "Luciano", "Murphy", 14, "63423322", 1, 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4313), new DateTime(1970, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "13398", "Luciano", "Murphy", 15, "94354820", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4339), new DateTime(1968, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "60346", "Hal", "Crissman", "29804126", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4360), new DateTime(1975, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "60346", "Hal", "Crissman", 12, "5159291", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4380), new DateTime(1967, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "60346", "Hal", "Crissman", 9, "52844157", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4406), new DateTime(1965, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "60346", "Hal", "Crissman", 8, "92551693", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4426), new DateTime(1992, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "60346", "Hal", "Crissman", 13, "50060371", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4545), new DateTime(1979, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "60346", "Hal", "Crissman", 15, "7220644", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4570), new DateTime(1987, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93029", "Benton", "Hennen", 10, "57584343", 2, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4591), new DateTime(1978, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "93029", "Benton", "Hennen", 17, "16147042", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4611), new DateTime(1988, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "93029", "Benton", "Hennen", 7, "31733782", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4637), new DateTime(1962, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "93029", "Benton", "Hennen", "985517", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4658), new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "93029", "Benton", "Hennen", 17, "54833959", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4678), new DateTime(1975, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "93029", "Benton", "Hennen", 14, "86191113", 2, 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4704), new DateTime(1974, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "81940", "Douglass", "Rolson", 6, "31856166", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4725), new DateTime(1977, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "81940", "Douglass", "Rolson", 10, "62400146", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4745), new DateTime(1965, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "81940", "Douglass", "Rolson", 16, "9860996", 1, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4771), new DateTime(1968, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "81940", "Douglass", "Rolson", 7, "20956132", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4791), new DateTime(1970, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "81940", "Douglass", "Rolson", 16, "82772399", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4853), new DateTime(1983, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "81940", "Douglass", "Rolson", 14, "64721206", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4879), new DateTime(1970, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "69070", "Douglass", "Momon", 10, "43504581", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4899), new DateTime(1969, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "69070", "Douglass", "Momon", 13, "12612030", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4925), new DateTime(1972, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "69070", "Douglass", "Momon", 10, "26493095", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4946), new DateTime(1982, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "69070", "Douglass", "Momon", 6, "26092003", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4966), new DateTime(1964, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "69070", "Douglass", "Momon", 16, "22938989", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4992), new DateTime(1994, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "69070", "Douglass", "Momon", 11, "30958824", 1, 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5018), new DateTime(2000, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "22883", "Rafael", "Zubizarreta", 7, "11617432", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5043), new DateTime(1999, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "22883", "Rafael", "Zubizarreta", 11, "97308503", 2, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5064), new DateTime(1963, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "22883", "Rafael", "Zubizarreta", 7, "2655874", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5156), new DateTime(1969, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "22883", "Rafael", "Zubizarreta", 13, "67852079", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5182), new DateTime(1992, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "22883", "Rafael", "Zubizarreta", 7, "70074667", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5208), new DateTime(1963, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "22883", "Rafael", "Zubizarreta", "88601115", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5228), new DateTime(1999, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "98307", "Jeromy", "Pantuso", 7, "64654813", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5249), new DateTime(1971, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "98307", "Jeromy", "Pantuso", 13, "93500215", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5275), new DateTime(1975, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "98307", "Jeromy", "Pantuso", 13, "28134010", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5295), new DateTime(1974, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "98307", "Jeromy", "Pantuso", 14, "23249536", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5316), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "98307", "Jeromy", "Pantuso", 16, "82244968", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5336), new DateTime(1982, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "98307", "Jeromy", "Pantuso", 10, "61537359" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5362), new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "85843", "Isaiah", "Sheman", 16, "26114675", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5383), new DateTime(1962, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85843", "Isaiah", "Sheman", 14, "98522963", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5403), new DateTime(1983, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "85843", "Isaiah", "Sheman", 8, "14816814", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5501), new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "85843", "Isaiah", "Sheman", 6, "42575751", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5526), new DateTime(1972, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "85843", "Isaiah", "Sheman", 9, "64630267", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5552), new DateTime(1986, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "85843", "Isaiah", "Sheman", 6, "21322261", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5573), new DateTime(1982, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "20482", "Delbert", "Nethken", 16, "42109855", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5598), new DateTime(1985, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "20482", "Delbert", "Nethken", "93369368", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5619), new DateTime(1997, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "20482", "Delbert", "Nethken", 7, "72884737", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5640), new DateTime(1981, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20482", "Delbert", "Nethken", 12, "84512492", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5660), new DateTime(1993, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20482", "Delbert", "Nethken", 17, "52966243", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5686), new DateTime(1980, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "20482", "Delbert", "Nethken", 13, "11387677", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5706), new DateTime(1993, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "74369", "Marcelino", "Mormann", "23390603", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5727), new DateTime(1992, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "74369", "Marcelino", "Mormann", 15, "77936008", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5753), new DateTime(1975, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "74369", "Marcelino", "Mormann", 13, "98219233", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5830), new DateTime(1976, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "74369", "Marcelino", "Mormann", 13, "41323810", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5871), new DateTime(1973, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "74369", "Marcelino", "Mormann", 12, "93978651", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5897), new DateTime(1998, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "74369", "Marcelino", "Mormann", 11, "140673", 2, 2, 500m });
        }
    }
}
