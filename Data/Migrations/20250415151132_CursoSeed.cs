using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace POWApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class CursoSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfesorId",
                table: "Curso",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Descripcion", "FechaCreacion", "Nombre", "ProfesorId" },
                values: new object[,]
                {
                    { 1, "Aprende los fundamentos de C#", new DateTime(2025, 4, 15, 10, 11, 27, 622, DateTimeKind.Local).AddTicks(6769), "C# Básico", null },
                    { 2, "Desarrollo de aplicaciones web con ASP.NET", new DateTime(2025, 4, 15, 10, 11, 27, 622, DateTimeKind.Local).AddTicks(6787), "ASP.NET MVC", null },
                    { 3, "Consulta y diseño de bases de datos", new DateTime(2025, 4, 15, 10, 11, 27, 622, DateTimeKind.Local).AddTicks(6789), "SQL Server", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ProfesorId",
                table: "Curso",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
