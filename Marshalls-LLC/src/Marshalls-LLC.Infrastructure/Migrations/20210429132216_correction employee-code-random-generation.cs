using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class correctionemployeecoderandomgeneration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2021, 4, 29, 0, 34, 50, 980, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 104, DateTimeKind.Local).AddTicks(1711), new DateTime(1976, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "7423", "Carlton", "Jacka", 15, "67258263", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(2663), new DateTime(1978, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "7423", "Carlton", "Jacka", 10, "43399044", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3007), new DateTime(1992, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "7423", "Carlton", "Jacka", 7, "67090504", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3043), new DateTime(1973, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "7423", "Carlton", "Jacka", 11, "37794218", 1, 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3069), new DateTime(1994, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "7423", "Carlton", "Jacka", 10, "94474739", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3157), new DateTime(1980, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "7423", "Carlton", "Jacka", 12, "90819315", 2, 300m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3234), new DateTime(1963, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "36843", "Hank", "Bridgette", 11, "66398051", 1, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3259), new DateTime(1994, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "36843", "Hank", "Bridgette", 12, "32882391", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3285), new DateTime(1976, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "36843", "Hank", "Bridgette", 13, "71110050", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3306), new DateTime(1973, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "36843", "Hank", "Bridgette", 16, "53874900", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3336), new DateTime(1999, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "36843", "Hank", "Bridgette", 6, "64252096", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3367), new DateTime(1976, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "43146", "Roberto", "Triplet", 13, "85680565", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3393), new DateTime(1974, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "43146", "Roberto", "Triplet", 16, "63664176", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3414), new DateTime(1972, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "43146", "Roberto", "Triplet", 13, "45382897", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3434), new DateTime(1991, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "43146", "Roberto", "Triplet", 13, "58271366", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3460), new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "43146", "Roberto", "Triplet", 15, "71729885", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3522), new DateTime(1992, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "43146", "Roberto", "Triplet", 15, "26316570" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3547), new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "25091", "Carlos", "Chrones", 11, "67430546", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3573), new DateTime(1992, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "25091", "Carlos", "Chrones", 15, "21151120", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3594), new DateTime(1983, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "25091", "Carlos", "Chrones", 13, "48899140", 2, 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3614), new DateTime(1980, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "25091", "Carlos", "Chrones", 9, "7353828", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3640), new DateTime(1976, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "25091", "Carlos", "Chrones", 14, "52229870", 1, 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3660), new DateTime(1983, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "25091", "Carlos", "Chrones", 11, "66711857" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3681), new DateTime(1978, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "95851", "Paris", "Schwall", 16, "28370041", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3707), new DateTime(1988, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "95851", "Paris", "Schwall", "27734849", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3727), new DateTime(1962, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "95851", "Paris", "Schwall", 6, "30311292", 2, 1, 500m });

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
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3830), new DateTime(1989, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "95851", "Paris", "Schwall", "76259756", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3871), new DateTime(1966, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "89673", "Martin", "Ailes", 15, "46304617", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3897), new DateTime(1982, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89673", "Martin", "Ailes", 17, "18603809", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3923), new DateTime(1978, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89673", "Martin", "Ailes", "834303", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3948), new DateTime(1963, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "89673", "Martin", "Ailes", 17, "30844454", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3969), new DateTime(1980, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "89673", "Martin", "Ailes", 10, "41775287", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(3995), new DateTime(1960, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "89673", "Martin", "Ailes", 16, "47400087", 1, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4015), new DateTime(1966, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "77469", "Dirk", "Binker", 15, "35467139", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4041), new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "77469", "Dirk", "Binker", 17, "86941039", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4061), new DateTime(1961, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "77469", "Dirk", "Binker", "67493640", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4082), new DateTime(1984, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "77469", "Dirk", "Binker", 13, "71540294", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4144), new DateTime(1971, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "77469", "Dirk", "Binker", 10, "20024907", 1, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4174), new DateTime(1964, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "77469", "Dirk", "Binker", 15, "52747339", 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4200), new DateTime(1979, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "13398", "Luciano", "Murphy", 9, "26551652", 2, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4226), new DateTime(1981, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "13398", "Luciano", "Murphy", 13, "33448457", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4246), new DateTime(1993, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "13398", "Luciano", "Murphy", 10, "26884455", 2, 2, 400m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4293), new DateTime(1987, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "13398", "Luciano", "Murphy", 14, "63423322", 2, 350m });

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
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4339), new DateTime(1968, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "60346", "Hal", "Crissman", 10, "29804126" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4360), new DateTime(1975, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "60346", "Hal", "Crissman", 12, "5159291", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4380), new DateTime(1967, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "60346", "Hal", "Crissman", 9, "52844157", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4406), new DateTime(1965, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "60346", "Hal", "Crissman", 8, "92551693", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4426), new DateTime(1992, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "60346", "Hal", "Crissman", 13, "50060371", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4545), new DateTime(1979, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "60346", "Hal", "Crissman", 15, "7220644", 2, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4570), new DateTime(1987, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "93029", "Benton", "Hennen", "57584343", 1, 700m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4611), new DateTime(1988, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "93029", "Benton", "Hennen", "31733782", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4637), new DateTime(1962, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "93029", "Benton", "Hennen", 8, "985517" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4658), new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "93029", "Benton", "Hennen", "54833959", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4678), new DateTime(1975, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "93029", "Benton", "Hennen", 14, "86191113", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4704), new DateTime(1974, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "81940", "Douglass", "Rolson", "31856166", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4725), new DateTime(1977, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "81940", "Douglass", "Rolson", 10, "62400146", 2, 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4745), new DateTime(1965, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "81940", "Douglass", "Rolson", 16, "9860996", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4771), new DateTime(1968, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "81940", "Douglass", "Rolson", 7, "20956132", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4791), new DateTime(1970, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "81940", "Douglass", "Rolson", 16, "82772399", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4853), new DateTime(1983, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "81940", "Douglass", "Rolson", 14, "64721206", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4879), new DateTime(1970, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "69070", "Douglass", "Momon", 10, "43504581", 2, 1, 250m });

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
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4925), new DateTime(1972, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "69070", "Douglass", "Momon", 10, "26493095", 1, 1 });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4966), new DateTime(1964, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "69070", "Douglass", "Momon", 16, "22938989", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(4992), new DateTime(1994, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "69070", "Douglass", "Momon", 11, "30958824", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5018), new DateTime(2000, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "22883", "Rafael", "Zubizarreta", 7, "11617432", 2, 2 });

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
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5064), new DateTime(1963, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "22883", "Rafael", "Zubizarreta", 7, "2655874", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5156), new DateTime(1969, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "22883", "Rafael", "Zubizarreta", 13, "67852079", 1, 2, 700m });

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
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5208), new DateTime(1963, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "22883", "Rafael", "Zubizarreta", 17, "88601115", 2, 2 });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5249), new DateTime(1971, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "98307", "Jeromy", "Pantuso", "93500215", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5275), new DateTime(1975, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "98307", "Jeromy", "Pantuso", 13, "28134010", 1, 1, 500m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5316), new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "98307", "Jeromy", "Pantuso", 16, "82244968", 2, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5336), new DateTime(1982, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "98307", "Jeromy", "Pantuso", 10, "61537359", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5362), new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "85843", "Isaiah", "Sheman", 16, "26114675", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5383), new DateTime(1962, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "85843", "Isaiah", "Sheman", 14, "98522963", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5403), new DateTime(1983, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "85843", "Isaiah", "Sheman", "14816814", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5501), new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "85843", "Isaiah", "Sheman", 6, "42575751", 700m });

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
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5552), new DateTime(1986, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "85843", "Isaiah", "Sheman", 6, "21322261", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5573), new DateTime(1982, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "20482", "Delbert", "Nethken", 16, "42109855", 2, 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5598), new DateTime(1985, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "20482", "Delbert", "Nethken", 14, "93369368", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5619), new DateTime(1997, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "20482", "Delbert", "Nethken", 7, "72884737", 1, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5640), new DateTime(1981, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20482", "Delbert", "Nethken", 12, "84512492", 1, 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5660), new DateTime(1993, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "20482", "Delbert", "Nethken", 17, "52966243", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5686), new DateTime(1980, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "20482", "Delbert", "Nethken", 13, "11387677", 1, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5706), new DateTime(1993, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "74369", "Marcelino", "Mormann", 14, "23390603" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5727), new DateTime(1992, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "74369", "Marcelino", "Mormann", 15, "77936008" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5753), new DateTime(1975, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "74369", "Marcelino", "Mormann", 13, "98219233", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5830), new DateTime(1976, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "74369", "Marcelino", "Mormann", 13, "41323810", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5871), new DateTime(1973, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "74369", "Marcelino", "Mormann", 12, "93978651", 1, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 8, 22, 15, 106, DateTimeKind.Local).AddTicks(5897), new DateTime(1998, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "74369", "Marcelino", "Mormann", 11, "140673", 500m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 29, 0, 34, 50, 980, DateTimeKind.Local).AddTicks(2939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 29, 8, 22, 15, 109, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 975, DateTimeKind.Local).AddTicks(3255), new DateTime(1980, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "65996", "Steve", "Heneisen", 16, "34024472", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2044), new DateTime(1973, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "40518", "Steve", "Heneisen", 11, "28067463", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2177), new DateTime(1979, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "47112", "Steve", "Heneisen", 13, "37577920", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2208), new DateTime(1986, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "96171", "Steve", "Heneisen", 7, "61989219", 2, 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2234), new DateTime(1999, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "75038", "Steve", "Heneisen", 8, "99449035", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2259), new DateTime(1975, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "36367", "Steve", "Heneisen", 17, "63674391", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2290), new DateTime(1982, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "79354", "Buford", "Mcelvy", 15, "11711268", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2316), new DateTime(1990, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "64512", "Buford", "Mcelvy", 6, "11327399", 2, 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2337), new DateTime(1981, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "75783", "Buford", "Mcelvy", 13, "53158441", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2357), new DateTime(1974, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "65840", "Buford", "Mcelvy", 17, "55399039", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2378), new DateTime(1997, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "19457", "Buford", "Mcelvy", 7, "38994745", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2455), new DateTime(1992, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "26289", "Buford", "Mcelvy", 9, "28317797", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2480), new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "67804", "Jacinto", "Feigh", 7, "39719331", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2501), new DateTime(1971, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "68306", "Jacinto", "Feigh", 8, "50389348", 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2522), new DateTime(1966, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "14470", "Jacinto", "Feigh", 14, "96577729", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2542), new DateTime(1987, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "13909", "Jacinto", "Feigh", 10, "5415688", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2563), new DateTime(1978, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "3535", "Jacinto", "Feigh", 6, "77209692", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2583), new DateTime(1997, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "99654", "Jacinto", "Feigh", 11, "62028410" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2609), new DateTime(1997, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "56312", "Walton", "Lesso", 16, "7365794", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2630), new DateTime(1976, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "29108", "Walton", "Lesso", 12, "33913762", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2650), new DateTime(1980, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "47650", "Walton", "Lesso", 12, "83932258", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2671), new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "10376", "Walton", "Lesso", 15, "84540477", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2691), new DateTime(1966, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "6948", "Walton", "Lesso", 11, "8390708", 2, 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2748), new DateTime(1965, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "38009", "Walton", "Lesso", 10, "74152821" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2768), new DateTime(1986, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "89396", "Darell", "Mofford", 8, "56033633", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2789), new DateTime(1990, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "35746", "Darell", "Mofford", "49321932", 1, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2809), new DateTime(1987, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "67996", "Darell", "Mofford", 10, "67930193", 1, 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2830), new DateTime(1972, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "81142", "Darell", "Mofford", 13, "97088350", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2851), new DateTime(1981, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "64041", "Darell", "Mofford", 14, "47448762", 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2871), new DateTime(1976, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "58778", "Darell", "Mofford", "21249195", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2897), new DateTime(1992, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "56194", "Kory", "Prevatte", 10, "59105561", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2917), new DateTime(1976, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "87852", "Kory", "Prevatte", 12, "9407172", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2938), new DateTime(1987, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "26375", "Kory", "Prevatte", "47628250", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2959), new DateTime(1969, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "90270", "Kory", "Prevatte", 14, "83548762", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3010), new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "60391", "Kory", "Prevatte", 17, "86185364", 1, 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3036), new DateTime(1990, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "67900", "Kory", "Prevatte", 14, "58437320", 2, 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3056), new DateTime(1987, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "29474", "Sheldon", "Mulligan", 12, "98258540", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3077), new DateTime(1976, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "86256", "Sheldon", "Mulligan", 10, "8887321", 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3097), new DateTime(1975, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "95433", "Sheldon", "Mulligan", "65050590", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3118), new DateTime(1982, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "29703", "Sheldon", "Mulligan", 15, "37985265", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3138), new DateTime(1960, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "33477", "Sheldon", "Mulligan", 14, "92393508", 2, 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3159), new DateTime(1990, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "16624", "Sheldon", "Mulligan", 13, "29652000", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3180), new DateTime(1990, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "86171", "Thurman", "Valado", 10, "42204473", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3200), new DateTime(1974, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "2715", "Thurman", "Valado", 15, "14348032", 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3221), new DateTime(1961, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "4467", "Thurman", "Valado", 17, "56667393", 1, 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3241), new DateTime(1961, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "98202", "Thurman", "Valado", 14, "23711782", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3303), new DateTime(1977, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "24166", "Thurman", "Valado", 11, "96755384", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3329), new DateTime(1970, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "31041", "Thurman", "Valado", 13, "3760865", 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3349), new DateTime(1974, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "71369", "Florentino", "Seara", 17, "9818676" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3370), new DateTime(1974, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "57503", "Florentino", "Seara", 15, "86240850", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3390), new DateTime(1999, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "43917", "Florentino", "Seara", 11, "60967777", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3411), new DateTime(1963, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "12038", "Florentino", "Seara", 6, "10868917", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3431), new DateTime(1990, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "26058", "Florentino", "Seara", 10, "48289795", 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3452), new DateTime(1988, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "99960", "Florentino", "Seara", 8, "96429893", 1, 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3473), new DateTime(1970, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "70392", "Jacques", "Vanhuss", "13828681", 2, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3493), new DateTime(1999, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "69194", "Jacques", "Vanhuss", 14, "95686274", 1, 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3514), new DateTime(1997, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "33950", "Jacques", "Vanhuss", "74083678", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3534), new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "12687", "Jacques", "Vanhuss", 10, "87789538" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3622), new DateTime(1969, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "24108", "Jacques", "Vanhuss", "71952311", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3647), new DateTime(1992, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "48078", "Jacques", "Vanhuss", 12, "50695772", 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3668), new DateTime(1996, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "85600", "Dario", "Dougharty", "34611707", 2, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3688), new DateTime(1980, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "93051", "Dario", "Dougharty", 13, "35737570", 1, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3709), new DateTime(1988, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "62760", "Dario", "Dougharty", 11, "57292021", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3730), new DateTime(1965, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "11130", "Dario", "Dougharty", 11, "75731492", 1, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3750), new DateTime(1991, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "4952", "Dario", "Dougharty", 9, "64896750", 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3771), new DateTime(1977, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "32436", "Dario", "Dougharty", 15, "32145053", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3796), new DateTime(1992, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "50065", "Brant", "Herdes", 14, "41604035", 1, 2, 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3817), new DateTime(1979, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "71798", "Brant", "Herdes", 15, "24432164", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3838), new DateTime(1992, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "1282", "Brant", "Herdes", 8, "57702871", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3894), new DateTime(1992, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "48153", "Brant", "Herdes", 15, "15593837", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3915), new DateTime(1995, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "36810", "Brant", "Herdes", 14, "80650499", 1, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3935), new DateTime(1989, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "91016", "Brant", "Herdes", 6, "53136041", 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3961), new DateTime(1976, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "97662", "Marcel", "Ekstrand", 9, "48388665", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3982), new DateTime(1963, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "34032", "Marcel", "Ekstrand", 15, "80583910", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3997), new DateTime(1979, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "6256", "Marcel", "Ekstrand", 17, "43211956", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4017), new DateTime(1992, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "32826", "Marcel", "Ekstrand", 11, "87766594", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4038), new DateTime(1999, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "92609", "Marcel", "Ekstrand", 13, "83475227", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4059), new DateTime(1980, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "81302", "Marcel", "Ekstrand", 15, "49583872", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4079), new DateTime(1961, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "97590", "Sean", "Winfough", 11, "34317104", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4100), new DateTime(1984, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "94808", "Sean", "Winfough", "62410568", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4120), new DateTime(1963, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "91641", "Sean", "Winfough", 10, "43549644", 2, 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4177), new DateTime(1978, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "55763", "Sean", "Winfough", 15, "33778139", 1, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4197), new DateTime(1988, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "21827", "Sean", "Winfough", 11, "59644297", 1, 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4218), new DateTime(1997, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "42281", "Sean", "Winfough", 7, "1919451", 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4239), new DateTime(1967, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, "15761", "Ezekiel", "Chaidy", 11, "69346628", 1, 700m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4259), new DateTime(1988, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "72608", "Ezekiel", "Chaidy", 10, "2869052", 2, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "IdentificationNumber", "OfficeId", "PositionId" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4280), new DateTime(1971, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "87262", "Ezekiel", "Chaidy", "96416831", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4300), new DateTime(1984, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, "29559", "Ezekiel", "Chaidy", 7, "40267382", 300m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4321), new DateTime(1964, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "40239", "Ezekiel", "Chaidy", 10, "14210118", 1, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4341), new DateTime(1982, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "18107", "Ezekiel", "Chaidy", 14, "18834319", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4362), new DateTime(1977, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "80547", "Gerardo", "Priolean", 17, "97798796", 1, 2, 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4382), new DateTime(1970, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "12620", "Gerardo", "Priolean", 10, "89045898", 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4403), new DateTime(1962, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, "54472", "Gerardo", "Priolean", 13, "19417893", 2, 2, 350m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4460), new DateTime(1964, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "91932", "Gerardo", "Priolean", 13, "47990367", 2, 1, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "PositionId", "ProductionBonus" },
                values: new object[] { 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4480), new DateTime(1961, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, "46931", "Gerardo", "Priolean", 10, "93509752", 1, 400m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4501), new DateTime(1995, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, "90644", "Gerardo", "Priolean", 11, "18011303", 2, 1, 250m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4526), new DateTime(1977, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "25223", "Wade", "Panfilov", 8, "13677655" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BeginDate", "Birthday", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4542), new DateTime(1960, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "61353", "Wade", "Panfilov", 9, "19210052" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4562), new DateTime(1999, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "74322", "Wade", "Panfilov", 17, "80819021", 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4583), new DateTime(1980, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "94854", "Wade", "Panfilov", 14, "9216671", 200m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "OfficeId", "PositionId", "ProductionBonus" },
                values: new object[] { 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4624), new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, "42643", "Wade", "Panfilov", 13, "78023616", 2, 2, 500m });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "ProductionBonus" },
                values: new object[] { 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4645), new DateTime(1979, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, "29610", "Wade", "Panfilov", 8, "52000820", 200m });
        }
    }
}
