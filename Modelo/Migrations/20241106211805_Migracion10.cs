using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BoletinCerrado1",
                table: "Boletines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BoletinCerrado2",
                table: "Boletines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BoletinCerrado3",
                table: "Boletines",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoletinCerrado1",
                table: "Boletines");

            migrationBuilder.DropColumn(
                name: "BoletinCerrado2",
                table: "Boletines");

            migrationBuilder.DropColumn(
                name: "BoletinCerrado3",
                table: "Boletines");
        }
    }
}
