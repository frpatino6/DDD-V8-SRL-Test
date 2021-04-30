using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class refreshinitialdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 29, 21, 56, 4, 633, DateTimeKind.Local).AddTicks(6292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 29, 20, 34, 40, 298, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 628, DateTimeKind.Local).AddTicks(3607), new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "21883", "Emmanuel", "Sasportas", 9, "51549709", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 628, DateTimeKind.Local).AddTicks(3607), new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "21883", "Emmanuel", "Sasportas", 9, "51549709", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 628, DateTimeKind.Local).AddTicks(3607), new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "21883", "Emmanuel", "Sasportas", 9, "51549709", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 628, DateTimeKind.Local).AddTicks(3607), new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "21883", "Emmanuel", "Sasportas", 9, "51549709", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 628, DateTimeKind.Local).AddTicks(3607), new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "21883", "Emmanuel", "Sasportas", 9, "51549709", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 628, DateTimeKind.Local).AddTicks(3607), new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "21883", "Emmanuel", "Sasportas", 9, "51549709", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2431), new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17457", "Lionel", "Destefano", 17, "71310389", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2431), new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17457", "Lionel", "Destefano", 17, "71310389", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2431), new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17457", "Lionel", "Destefano", 17, "71310389", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2431), new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17457", "Lionel", "Destefano", 17, "71310389", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2431), new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17457", "Lionel", "Destefano", 17, "71310389", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2431), new DateTime(1976, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "17457", "Lionel", "Destefano", 17, "71310389", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2575), new DateTime(1996, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "41989", "Trevor", "Cidre", 10, "69103666", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2575), new DateTime(1996, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "41989", "Trevor", "Cidre", 10, "69103666", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2575), new DateTime(1996, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "41989", "Trevor", "Cidre", 10, "69103666", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2575), new DateTime(1996, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "41989", "Trevor", "Cidre", 10, "69103666", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2575), new DateTime(1996, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "41989", "Trevor", "Cidre", 10, "69103666", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2575), new DateTime(1996, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "41989", "Trevor", "Cidre", 10, "69103666", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2729), new DateTime(1970, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "23372", "Dalton", "Neault", 11, "7349931", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2729), new DateTime(1970, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "23372", "Dalton", "Neault", 11, "7349931", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2729), new DateTime(1970, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "23372", "Dalton", "Neault", 11, "7349931", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2729), new DateTime(1970, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "23372", "Dalton", "Neault", 11, "7349931", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2729), new DateTime(1970, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "23372", "Dalton", "Neault", 11, "7349931", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2729), new DateTime(1970, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "23372", "Dalton", "Neault", 11, "7349931", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2847), new DateTime(1966, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13828", "Neil", "Donchez", "45993702", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2847), new DateTime(1966, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13828", "Neil", "Donchez", "45993702", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2847), new DateTime(1966, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13828", "Neil", "Donchez", "45993702", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2847), new DateTime(1966, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13828", "Neil", "Donchez", "45993702", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2847), new DateTime(1966, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13828", "Neil", "Donchez", "45993702", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2847), new DateTime(1966, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "13828", "Neil", "Donchez", "45993702", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2997), new DateTime(1982, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "69921", "Byron", "Robasciotti", 13, "80109030", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2997), new DateTime(1982, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "69921", "Byron", "Robasciotti", 13, "80109030", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2997), new DateTime(1982, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "69921", "Byron", "Robasciotti", 13, "80109030", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2997), new DateTime(1982, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "69921", "Byron", "Robasciotti", 13, "80109030", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2997), new DateTime(1982, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "69921", "Byron", "Robasciotti", 13, "80109030", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(2997), new DateTime(1982, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "69921", "Byron", "Robasciotti", 13, "80109030", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3115), new DateTime(1975, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "11463", "Jarvis", "Bartnick", 7, "82888295", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3115), new DateTime(1975, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "11463", "Jarvis", "Bartnick", 7, "82888295", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3115), new DateTime(1975, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "11463", "Jarvis", "Bartnick", 7, "82888295", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3115), new DateTime(1975, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "11463", "Jarvis", "Bartnick", 7, "82888295", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3115), new DateTime(1975, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "11463", "Jarvis", "Bartnick", 7, "82888295", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3115), new DateTime(1975, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "11463", "Jarvis", "Bartnick", 7, "82888295", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3259), new DateTime(1961, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "45757", "Hollis", "Erlwein", 10, "85449924", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3259), new DateTime(1961, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "45757", "Hollis", "Erlwein", 10, "85449924", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3259), new DateTime(1961, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "45757", "Hollis", "Erlwein", 10, "85449924", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3259), new DateTime(1961, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "45757", "Hollis", "Erlwein", 10, "85449924", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3259), new DateTime(1961, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "45757", "Hollis", "Erlwein", 10, "85449924", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3259), new DateTime(1961, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "45757", "Hollis", "Erlwein", 10, "85449924", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3377), new DateTime(1964, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "38971", "Osvaldo", "Ditchfield", 6, "24254528", 2, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3377), new DateTime(1964, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "38971", "Osvaldo", "Ditchfield", 6, "24254528", 2, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3377), new DateTime(1964, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "38971", "Osvaldo", "Ditchfield", 6, "24254528", 2, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3377), new DateTime(1964, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "38971", "Osvaldo", "Ditchfield", 6, "24254528", 2, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3377), new DateTime(1964, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "38971", "Osvaldo", "Ditchfield", 6, "24254528", 2, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3377), new DateTime(1964, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "38971", "Osvaldo", "Ditchfield", 6, "24254528", 2, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3783), new DateTime(1968, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "23204", "Sherwood", "Tayor", 6, "51301202", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3783), new DateTime(1968, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "23204", "Sherwood", "Tayor", 6, "51301202", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3783), new DateTime(1968, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "23204", "Sherwood", "Tayor", 6, "51301202", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3783), new DateTime(1968, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "23204", "Sherwood", "Tayor", 6, "51301202", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3783), new DateTime(1968, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "23204", "Sherwood", "Tayor", 6, "51301202", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3783), new DateTime(1968, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "23204", "Sherwood", "Tayor", 6, "51301202", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3912), new DateTime(1982, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40206", "Sydney", "Milfort", 16, "65929115", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3912), new DateTime(1982, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40206", "Sydney", "Milfort", 16, "65929115", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3912), new DateTime(1982, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40206", "Sydney", "Milfort", 16, "65929115", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3912), new DateTime(1982, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40206", "Sydney", "Milfort", 16, "65929115", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3912), new DateTime(1982, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40206", "Sydney", "Milfort", 16, "65929115", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(3912), new DateTime(1982, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "40206", "Sydney", "Milfort", 16, "65929115", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4091), new DateTime(1966, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "71422", "Howard", "Reigh", 17, "72759627", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4091), new DateTime(1966, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "71422", "Howard", "Reigh", 17, "72759627", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4091), new DateTime(1966, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "71422", "Howard", "Reigh", 17, "72759627", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4091), new DateTime(1966, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "71422", "Howard", "Reigh", 17, "72759627", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4091), new DateTime(1966, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "71422", "Howard", "Reigh", 17, "72759627", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4091), new DateTime(1966, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "71422", "Howard", "Reigh", 17, "72759627", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4256), new DateTime(1973, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "43607", "Damion", "Degraw", 11, "51995826", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4256), new DateTime(1973, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "43607", "Damion", "Degraw", 11, "51995826", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4256), new DateTime(1973, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "43607", "Damion", "Degraw", 11, "51995826", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4256), new DateTime(1973, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "43607", "Damion", "Degraw", 11, "51995826", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4256), new DateTime(1973, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "43607", "Damion", "Degraw", 11, "51995826", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4256), new DateTime(1973, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "43607", "Damion", "Degraw", 11, "51995826", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4390), new DateTime(1986, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "85515", "Louie", "Govea", 15, "51103482", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4390), new DateTime(1986, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "85515", "Louie", "Govea", 15, "51103482", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4390), new DateTime(1986, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "85515", "Louie", "Govea", 15, "51103482", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4390), new DateTime(1986, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "85515", "Louie", "Govea", 15, "51103482", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4390), new DateTime(1986, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "85515", "Louie", "Govea", 15, "51103482", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4390), new DateTime(1986, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "85515", "Louie", "Govea", 15, "51103482", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4549), new DateTime(1997, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93242", "Cary", "Turnball", 8, "71424791", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4549), new DateTime(1997, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93242", "Cary", "Turnball", 8, "71424791", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4549), new DateTime(1997, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93242", "Cary", "Turnball", 8, "71424791", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4549), new DateTime(1997, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93242", "Cary", "Turnball", 8, "71424791", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4549), new DateTime(1997, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93242", "Cary", "Turnball", 8, "71424791", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4549), new DateTime(1997, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93242", "Cary", "Turnball", 8, "71424791", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4852), new DateTime(1993, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "94509", "Rueben", "Gentilcore", 9, "28979667", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4852), new DateTime(1993, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "94509", "Rueben", "Gentilcore", 9, "28979667", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4852), new DateTime(1993, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "94509", "Rueben", "Gentilcore", 9, "28979667", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4852), new DateTime(1993, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "94509", "Rueben", "Gentilcore", 9, "28979667", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4852), new DateTime(1993, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "94509", "Rueben", "Gentilcore", 9, "28979667", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(4852), new DateTime(1993, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "94509", "Rueben", "Gentilcore", 9, "28979667", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(5043), new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89283", "Harland", "Goudeau", 14, "85396130", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(5043), new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89283", "Harland", "Goudeau", 14, "85396130", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(5043), new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89283", "Harland", "Goudeau", 14, "85396130", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(5043), new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89283", "Harland", "Goudeau", 14, "85396130", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(5043), new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89283", "Harland", "Goudeau", 14, "85396130", 2, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 21, 56, 4, 630, DateTimeKind.Local).AddTicks(5043), new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89283", "Harland", "Goudeau", 14, "85396130", 2, 2, 300m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2021, 4, 29, 21, 56, 4, 633, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "13596", "Owen", "Zarillo", 11, "43898990", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "13596", "Owen", "Zarillo", 11, "43898990", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "13596", "Owen", "Zarillo", 11, "43898990", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "13596", "Owen", "Zarillo", 11, "43898990", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "13596", "Owen", "Zarillo", 11, "43898990", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 293, DateTimeKind.Local).AddTicks(6728), new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "13596", "Owen", "Zarillo", 11, "43898990", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3651), new DateTime(1982, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "28560", "Gene", "Fondriest", 11, "13784476", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", "61687118", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(3985), new DateTime(1973, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "68645", "Javier", "Foot", "61687118", 1, 200m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4217), new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "83951", "Geraldo", "Guialdo", 16, "4413439", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4356), new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "11579", "Elton", "Larizza", 11, "37861942", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4443), new DateTime(1989, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "53171", "Preston", "Castoral", 16, "67080811", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", 8, "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", 8, "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", 8, "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", 8, "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", 8, "54585969", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4582), new DateTime(1992, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "58198", "Alonso", "Lauinger", 8, "54585969", 500m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4870), new DateTime(1975, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "91612", "Sid", "Arzate", 15, "53285636", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "84889", "Kareem", "Asif", 12, "87158345", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "84889", "Kareem", "Asif", 12, "87158345", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "84889", "Kareem", "Asif", 12, "87158345", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "84889", "Kareem", "Asif", 12, "87158345", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "84889", "Kareem", "Asif", 12, "87158345", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(4957), new DateTime(1961, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "84889", "Kareem", "Asif", 12, "87158345", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5091), new DateTime(1972, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "84293", "Mariano", "Lorona", 14, "97594579", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5178), new DateTime(1995, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "72519", "Herbert", "Lagarde", 10, "12406209", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5307), new DateTime(1991, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36246", "Ruben", "Rivara", 16, "91093862", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 1, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 20, 34, 40, 295, DateTimeKind.Local).AddTicks(5394), new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "43610", "Tyler", "Stuck", 17, "69337156", 1, 1, 350m });
        }
    }
}
