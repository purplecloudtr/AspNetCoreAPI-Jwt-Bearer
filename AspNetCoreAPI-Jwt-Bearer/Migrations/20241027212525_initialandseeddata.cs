using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreAPI_Jwt_Bearer.Migrations
{
    /// <inheritdoc />
    public partial class initialandseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "BeginDate",
                value: new DateTime(2024, 10, 28, 0, 25, 24, 833, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "BeginDate",
                value: new DateTime(2024, 10, 28, 0, 25, 24, 833, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "BeginDate",
                value: new DateTime(2024, 10, 28, 0, 25, 24, 833, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "BeginDate",
                value: new DateTime(2024, 10, 28, 0, 25, 24, 833, DateTimeKind.Local).AddTicks(1516));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "BeginDate",
                value: new DateTime(2024, 8, 22, 20, 10, 59, 292, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "BeginDate",
                value: new DateTime(2024, 8, 22, 20, 10, 59, 292, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "BeginDate",
                value: new DateTime(2024, 8, 22, 20, 10, 59, 292, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "BeginDate",
                value: new DateTime(2024, 8, 22, 20, 10, 59, 292, DateTimeKind.Local).AddTicks(5962));
        }
    }
}
