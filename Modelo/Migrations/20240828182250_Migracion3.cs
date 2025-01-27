using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sexos",
                columns: new[] { "SexoId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "A1", "Masculino" },
                    { 2, "A2", "Femenino" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sexos",
                keyColumn: "SexoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sexos",
                keyColumn: "SexoId",
                keyValue: 2);
        }
    }
}
