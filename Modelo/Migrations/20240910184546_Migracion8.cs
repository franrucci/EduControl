using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PromedioAsistenciaTrimestre1",
                table: "Boletines",
                type: "decimal(4,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PromedioAsistenciaTrimestre2",
                table: "Boletines",
                type: "decimal(4,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PromedioAsistenciaTrimestre3",
                table: "Boletines",
                type: "decimal(4,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PromedioTotalAsistencia",
                table: "Boletines",
                type: "decimal(4,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PromedioTotalExamenes",
                table: "Boletines",
                type: "decimal(4,1)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PromedioAsistenciaTrimestre1",
                table: "Boletines");

            migrationBuilder.DropColumn(
                name: "PromedioAsistenciaTrimestre2",
                table: "Boletines");

            migrationBuilder.DropColumn(
                name: "PromedioAsistenciaTrimestre3",
                table: "Boletines");

            migrationBuilder.DropColumn(
                name: "PromedioTotalAsistencia",
                table: "Boletines");

            migrationBuilder.DropColumn(
                name: "PromedioTotalExamenes",
                table: "Boletines");
        }
    }
}
