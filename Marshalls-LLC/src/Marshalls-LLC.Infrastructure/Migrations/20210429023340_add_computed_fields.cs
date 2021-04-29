using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshalls_LLC.Infrastructure.Migrations
{
    public partial class add_computed_fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProductionBonus",
                table: "Employee",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Contributions",
                table: "Employee",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "CompensationBonus",
                table: "Employee",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Commission",
                table: "Employee",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 28, 21, 33, 39, 856, DateTimeKind.Local).AddTicks(2296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 28, 17, 38, 3, 626, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.AlterColumn<decimal>(
                name: "BaseSalary",
                table: "Employee",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ProductionBonus",
                table: "Employee",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Contributions",
                table: "Employee",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "CompensationBonus",
                table: "Employee",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Commission",
                table: "Employee",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Employee",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 4, 28, 17, 38, 3, 626, DateTimeKind.Local).AddTicks(6683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 4, 28, 21, 33, 39, 856, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.AlterColumn<double>(
                name: "BaseSalary",
                table: "Employee",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
