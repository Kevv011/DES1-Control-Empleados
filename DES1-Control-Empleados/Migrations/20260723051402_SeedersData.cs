using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DES1_Control_Empleados.Migrations
{
    /// <inheritdoc />
    public partial class SeedersData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "DEP-RH", "Gestión de talento humano", "Recursos Humanos" },
                    { 2, "DEP-TI", "Sistemas y desarrollo", "Tecnología" },
                    { 3, "DEP-VEN", "Ventas y marketing", "Ventas" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "Code", "Description", "HireDate", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, new DateOnly(1985, 5, 20), "EMP-001", null, new DateTime(2010, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 50000m },
                    { 2, new DateOnly(1990, 3, 10), "EMP-002", null, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 70000m },
                    { 3, new DateOnly(1982, 11, 22), "EMP-003", null, new DateTime(2012, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark Johnson", 55000m },
                    { 4, new DateOnly(1978, 7, 30), "EMP-004", null, new DateTime(2005, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily Davis", 75000m },
                    { 5, new DateOnly(1995, 12, 5), "EMP-005", null, new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Brown", 60000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
