using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Pagos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql("ALTER TABLE Cuotas DROP COLUMN Mes;");
            migrationBuilder.AddColumn<int>(
                name: "Mes",
                table: "Cuotas",
                nullable: false,
                defaultValue: 0); // O un valor por defecto adecuado

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Cuotas",
                type: "decimal(4,1)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Cuotas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Mes",
                table: "Cuotas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
