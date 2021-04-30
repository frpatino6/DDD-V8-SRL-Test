using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class seedsemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Division_DivisionId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "DivisionId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 29, 0, 34, 50, 980, DateTimeKind.Local).AddTicks(2939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 28, 21, 33, 39, 856, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 1, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 975, DateTimeKind.Local).AddTicks(3255), new DateTime(1980, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "65996", "Steve", "Heneisen", 16, "34024472", 1, 2, 1, 200m, 2020 },
                    { 74, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3982), new DateTime(1963, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "34032", "Marcel", "Ekstrand", 15, "80583910", 2, 1, 2, 200m, 2020 },
                    { 73, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3961), new DateTime(1976, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "97662", "Marcel", "Ekstrand", 9, "48388665", 1, 1, 1, 500m, 2020 },
                    { 72, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3935), new DateTime(1989, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "91016", "Brant", "Herdes", 6, "53136041", 6, 2, 2, 200m, 2020 },
                    { 71, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3915), new DateTime(1995, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "36810", "Brant", "Herdes", 14, "80650499", 5, 1, 1, 200m, 2020 },
                    { 70, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3894), new DateTime(1992, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "48153", "Brant", "Herdes", 15, "15593837", 4, 2, 1, 700m, 2020 },
                    { 69, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3838), new DateTime(1992, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "1282", "Brant", "Herdes", 8, "57702871", 3, 2, 2, 250m, 2020 },
                    { 68, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3817), new DateTime(1979, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "71798", "Brant", "Herdes", 15, "24432164", 2, 2, 1, 300m, 2020 },
                    { 67, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3796), new DateTime(1992, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "50065", "Brant", "Herdes", 14, "41604035", 1, 1, 2, 300m, 2020 },
                    { 66, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3771), new DateTime(1977, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "32436", "Dario", "Dougharty", 15, "32145053", 6, 1, 2, 300m, 2020 },
                    { 65, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3750), new DateTime(1991, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "4952", "Dario", "Dougharty", 9, "64896750", 5, 1, 2, 350m, 2020 },
                    { 64, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3730), new DateTime(1965, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "11130", "Dario", "Dougharty", 11, "75731492", 4, 1, 1, 250m, 2020 },
                    { 63, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3709), new DateTime(1988, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "62760", "Dario", "Dougharty", 11, "57292021", 3, 1, 2, 250m, 2020 },
                    { 62, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3688), new DateTime(1980, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "93051", "Dario", "Dougharty", 13, "35737570", 2, 1, 2, 400m, 2020 },
                    { 61, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3668), new DateTime(1996, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "85600", "Dario", "Dougharty", 6, "34611707", 1, 2, 2, 700m, 2020 },
                    { 60, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3647), new DateTime(1992, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "48078", "Jacques", "Vanhuss", 12, "50695772", 6, 2, 1, 400m, 2020 },
                    { 59, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3622), new DateTime(1969, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "24108", "Jacques", "Vanhuss", 17, "71952311", 5, 2, 2, 500m, 2020 },
                    { 58, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3534), new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "12687", "Jacques", "Vanhuss", 10, "87789538", 4, 1, 1, 200m, 2020 },
                    { 57, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3514), new DateTime(1997, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "33950", "Jacques", "Vanhuss", 7, "74083678", 3, 2, 1, 400m, 2020 },
                    { 56, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3493), new DateTime(1999, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "69194", "Jacques", "Vanhuss", 14, "95686274", 2, 1, 2, 350m, 2020 },
                    { 55, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3473), new DateTime(1970, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "70392", "Jacques", "Vanhuss", 10, "13828681", 1, 2, 2, 250m, 2020 },
                    { 54, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3452), new DateTime(1988, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "99960", "Florentino", "Seara", 8, "96429893", 6, 1, 1, 400m, 2020 },
                    { 75, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3997), new DateTime(1979, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "6256", "Marcel", "Ekstrand", 17, "43211956", 3, 2, 1, 350m, 2020 },
                    { 76, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4017), new DateTime(1992, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "32826", "Marcel", "Ekstrand", 11, "87766594", 4, 2, 1, 500m, 2020 },
                    { 77, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4038), new DateTime(1999, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "92609", "Marcel", "Ekstrand", 13, "83475227", 5, 1, 2, 400m, 2020 },
                    { 78, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4059), new DateTime(1980, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "81302", "Marcel", "Ekstrand", 15, "49583872", 6, 1, 1, 350m, 2020 },
                    { 100, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4583), new DateTime(1980, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "94854", "Wade", "Panfilov", 14, "9216671", 4, 1, 2, 200m, 2020 },
                    { 99, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4562), new DateTime(1999, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "74322", "Wade", "Panfilov", 17, "80819021", 3, 2, 2, 500m, 2020 },
                    { 98, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4542), new DateTime(1960, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "61353", "Wade", "Panfilov", 9, "19210052", 2, 2, 2, 400m, 2020 },
                    { 97, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4526), new DateTime(1977, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "25223", "Wade", "Panfilov", 8, "13677655", 1, 1, 1, 500m, 2020 },
                    { 96, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4501), new DateTime(1995, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "90644", "Gerardo", "Priolean", 11, "18011303", 6, 2, 1, 250m, 2020 },
                    { 95, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4480), new DateTime(1961, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "46931", "Gerardo", "Priolean", 10, "93509752", 5, 2, 1, 400m, 2020 },
                    { 94, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4460), new DateTime(1964, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "91932", "Gerardo", "Priolean", 13, "47990367", 4, 2, 1, 500m, 2020 },
                    { 93, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4403), new DateTime(1962, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "54472", "Gerardo", "Priolean", 13, "19417893", 3, 2, 2, 350m, 2020 },
                    { 92, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4382), new DateTime(1970, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "12620", "Gerardo", "Priolean", 10, "89045898", 2, 1, 2, 500m, 2020 },
                    { 91, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4362), new DateTime(1977, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "80547", "Gerardo", "Priolean", 17, "97798796", 1, 1, 2, 200m, 2020 },
                    { 53, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3431), new DateTime(1990, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "26058", "Florentino", "Seara", 10, "48289795", 5, 1, 1, 250m, 2020 },
                    { 90, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4341), new DateTime(1982, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "18107", "Ezekiel", "Chaidy", 14, "18834319", 6, 1, 1, 400m, 2020 },
                    { 88, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4300), new DateTime(1984, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "29559", "Ezekiel", "Chaidy", 7, "40267382", 4, 1, 2, 300m, 2020 },
                    { 87, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4280), new DateTime(1971, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "87262", "Ezekiel", "Chaidy", 8, "96416831", 3, 2, 1, 250m, 2020 },
                    { 86, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4259), new DateTime(1988, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "72608", "Ezekiel", "Chaidy", 10, "2869052", 2, 2, 1, 400m, 2020 },
                    { 85, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4239), new DateTime(1967, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "15761", "Ezekiel", "Chaidy", 11, "69346628", 1, 2, 1, 700m, 2020 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 84, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4218), new DateTime(1997, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "42281", "Sean", "Winfough", 7, "1919451", 6, 1, 2, 350m, 2020 },
                    { 83, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4197), new DateTime(1988, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "21827", "Sean", "Winfough", 11, "59644297", 5, 1, 2, 400m, 2020 },
                    { 82, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4177), new DateTime(1978, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "55763", "Sean", "Winfough", 15, "33778139", 4, 1, 1, 350m, 2020 },
                    { 81, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4120), new DateTime(1963, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "91641", "Sean", "Winfough", 10, "43549644", 3, 2, 2, 350m, 2020 },
                    { 80, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4100), new DateTime(1984, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "94808", "Sean", "Winfough", 13, "62410568", 2, 2, 1, 400m, 2020 },
                    { 79, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4079), new DateTime(1961, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "97590", "Sean", "Winfough", 11, "34317104", 1, 1, 1, 350m, 2020 },
                    { 89, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4321), new DateTime(1964, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "40239", "Ezekiel", "Chaidy", 10, "14210118", 5, 1, 1, 250m, 2020 },
                    { 52, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3411), new DateTime(1963, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "12038", "Florentino", "Seara", 6, "10868917", 4, 2, 2, 500m, 2020 },
                    { 51, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3390), new DateTime(1999, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "43917", "Florentino", "Seara", 11, "60967777", 3, 1, 1, 300m, 2020 },
                    { 50, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3370), new DateTime(1974, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "57503", "Florentino", "Seara", 15, "86240850", 2, 2, 1, 200m, 2020 },
                    { 23, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2691), new DateTime(1966, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "6948", "Walton", "Lesso", 11, "8390708", 5, 2, 1, 200m, 2020 },
                    { 22, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2671), new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "10376", "Walton", "Lesso", 15, "84540477", 4, 2, 1, 300m, 2020 },
                    { 21, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2650), new DateTime(1980, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "47650", "Walton", "Lesso", 12, "83932258", 3, 1, 2, 300m, 2020 },
                    { 20, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2630), new DateTime(1976, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "29108", "Walton", "Lesso", 12, "33913762", 2, 1, 1, 400m, 2020 },
                    { 19, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2609), new DateTime(1997, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "56312", "Walton", "Lesso", 16, "7365794", 1, 2, 1, 400m, 2020 },
                    { 18, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2583), new DateTime(1997, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "99654", "Jacinto", "Feigh", 11, "62028410", 6, 1, 2, 300m, 2020 },
                    { 17, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2563), new DateTime(1978, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "3535", "Jacinto", "Feigh", 6, "77209692", 5, 1, 2, 400m, 2020 },
                    { 16, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2542), new DateTime(1987, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "13909", "Jacinto", "Feigh", 10, "5415688", 4, 1, 1, 250m, 2020 },
                    { 15, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2522), new DateTime(1966, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "14470", "Jacinto", "Feigh", 14, "96577729", 3, 1, 1, 500m, 2020 },
                    { 14, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2501), new DateTime(1971, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "68306", "Jacinto", "Feigh", 8, "50389348", 2, 2, 1, 500m, 2020 },
                    { 24, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2748), new DateTime(1965, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "38009", "Walton", "Lesso", 10, "74152821", 6, 2, 1, 350m, 2020 },
                    { 13, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2480), new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "67804", "Jacinto", "Feigh", 7, "39719331", 1, 2, 1, 250m, 2020 },
                    { 11, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2378), new DateTime(1997, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "19457", "Buford", "Mcelvy", 7, "38994745", 5, 2, 1, 200m, 2020 },
                    { 10, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2357), new DateTime(1974, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "65840", "Buford", "Mcelvy", 17, "55399039", 4, 2, 1, 300m, 2020 },
                    { 9, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2337), new DateTime(1981, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "75783", "Buford", "Mcelvy", 13, "53158441", 3, 1, 2, 400m, 2020 },
                    { 8, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2316), new DateTime(1990, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "64512", "Buford", "Mcelvy", 6, "11327399", 2, 2, 1, 200m, 2020 },
                    { 7, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2290), new DateTime(1982, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "79354", "Buford", "Mcelvy", 15, "11711268", 1, 1, 2, 400m, 2020 },
                    { 6, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2259), new DateTime(1975, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "36367", "Steve", "Heneisen", 17, "63674391", 6, 1, 1, 200m, 2020 },
                    { 5, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2234), new DateTime(1999, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "75038", "Steve", "Heneisen", 8, "99449035", 5, 2, 1, 700m, 2020 },
                    { 4, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2208), new DateTime(1986, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "96171", "Steve", "Heneisen", 7, "61989219", 4, 2, 1, 300m, 2020 },
                    { 3, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2177), new DateTime(1979, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "47112", "Steve", "Heneisen", 13, "37577920", 3, 1, 1, 700m, 2020 },
                    { 2, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2044), new DateTime(1973, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "40518", "Steve", "Heneisen", 11, "28067463", 2, 2, 1, 250m, 2020 },
                    { 12, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2455), new DateTime(1992, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "26289", "Buford", "Mcelvy", 9, "28317797", 6, 1, 2, 250m, 2020 },
                    { 101, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4624), new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "42643", "Wade", "Panfilov", 13, "78023616", 5, 2, 2, 500m, 2020 },
                    { 25, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2768), new DateTime(1986, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "89396", "Darell", "Mofford", 8, "56033633", 1, 1, 2, 300m, 2020 },
                    { 27, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2809), new DateTime(1987, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "67996", "Darell", "Mofford", 10, "67930193", 3, 1, 2, 350m, 2020 },
                    { 49, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3349), new DateTime(1974, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "71369", "Florentino", "Seara", 17, "9818676", 1, 1, 1, 700m, 2020 },
                    { 48, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3329), new DateTime(1970, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "31041", "Thurman", "Valado", 13, "3760865", 6, 2, 1, 700m, 2020 },
                    { 47, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3303), new DateTime(1977, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "24166", "Thurman", "Valado", 11, "96755384", 5, 1, 1, 400m, 2020 },
                    { 46, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3241), new DateTime(1961, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "98202", "Thurman", "Valado", 14, "23711782", 4, 2, 1, 250m, 2020 },
                    { 45, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3221), new DateTime(1961, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "4467", "Thurman", "Valado", 17, "56667393", 3, 1, 1, 700m, 2020 },
                    { 44, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3200), new DateTime(1974, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "2715", "Thurman", "Valado", 15, "14348032", 2, 2, 2, 350m, 2020 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Year" },
                values: new object[,]
                {
                    { 43, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3180), new DateTime(1990, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "86171", "Thurman", "Valado", 10, "42204473", 1, 1, 1, 700m, 2020 },
                    { 42, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3159), new DateTime(1990, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "16624", "Sheldon", "Mulligan", 13, "29652000", 6, 2, 2, 400m, 2020 },
                    { 41, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3138), new DateTime(1960, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "33477", "Sheldon", "Mulligan", 14, "92393508", 5, 2, 2, 700m, 2020 },
                    { 40, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3118), new DateTime(1982, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "29703", "Sheldon", "Mulligan", 15, "37985265", 4, 1, 1, 200m, 2020 },
                    { 26, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2789), new DateTime(1990, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "35746", "Darell", "Mofford", 16, "49321932", 2, 2, 1, 300m, 2020 },
                    { 39, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3097), new DateTime(1975, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "95433", "Sheldon", "Mulligan", 6, "65050590", 3, 1, 2, 700m, 2020 },
                    { 37, 7000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3056), new DateTime(1987, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 350m, 210m, 1, "29474", "Sheldon", "Mulligan", 12, "98258540", 1, 2, 1, 700m, 2020 },
                    { 36, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3036), new DateTime(1990, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "67900", "Kory", "Prevatte", 14, "58437320", 6, 2, 1, 200m, 2020 },
                    { 35, 2500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3010), new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m, 125m, 75m, 1, "60391", "Kory", "Prevatte", 17, "86185364", 5, 1, 2, 250m, 2020 },
                    { 34, 3500m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2959), new DateTime(1969, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m, 175m, 105m, 1, "90270", "Kory", "Prevatte", 14, "83548762", 4, 1, 1, 350m, 2020 },
                    { 33, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2938), new DateTime(1987, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "26375", "Kory", "Prevatte", 9, "47628250", 3, 1, 1, 200m, 2020 },
                    { 32, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2917), new DateTime(1976, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "87852", "Kory", "Prevatte", 12, "9407172", 2, 2, 2, 500m, 2020 },
                    { 31, 4000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2897), new DateTime(1992, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 200m, 120m, 1, "56194", "Kory", "Prevatte", 10, "59105561", 1, 2, 2, 400m, 2020 },
                    { 30, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2871), new DateTime(1976, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "58778", "Darell", "Mofford", 17, "21249195", 6, 2, 1, 200m, 2020 },
                    { 29, 3000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2851), new DateTime(1981, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, 150m, 90m, 1, "64041", "Darell", "Mofford", 14, "47448762", 5, 2, 1, 300m, 2020 },
                    { 28, 5000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(2830), new DateTime(1972, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 250m, 150m, 1, "81142", "Darell", "Mofford", 13, "97088350", 4, 2, 1, 500m, 2020 },
                    { 38, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(3077), new DateTime(1976, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "86256", "Sheldon", "Mulligan", 10, "8887321", 2, 1, 1, 200m, 2020 },
                    { 102, 2000m, new DateTime(2021, 4, 29, 0, 34, 50, 977, DateTimeKind.Local).AddTicks(4645), new DateTime(1979, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, 100m, 60m, 1, "29610", "Wade", "Panfilov", 8, "52000820", 6, 2, 2, 200m, 2020 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Division_DivisionId",
                table: "Employee",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Division_DivisionId",
                table: "Employee");

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.AlterColumn<int>(
                name: "DivisionId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 28, 21, 33, 39, 856, DateTimeKind.Local).AddTicks(2296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 29, 0, 34, 50, 980, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Division_DivisionId",
                table: "Employee",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
