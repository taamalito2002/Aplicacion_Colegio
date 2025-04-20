using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POWApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InicialFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 4, 16, 14, 52, 7, 565, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 4, 16, 14, 52, 7, 565, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 4, 16, 14, 52, 7, 565, DateTimeKind.Local).AddTicks(3111));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 4, 15, 10, 11, 27, 622, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 4, 15, 10, 11, 27, 622, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Curso",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 4, 15, 10, 11, 27, 622, DateTimeKind.Local).AddTicks(6789));
        }
    }
}
