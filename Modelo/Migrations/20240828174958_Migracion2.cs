using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Boletines_BoletinId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_BoletinId",
                table: "Personas");

            migrationBuilder.CreateIndex(
                name: "IX_Boletines_PersonaId",
                table: "Boletines",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boletines_Personas_PersonaId",
                table: "Boletines",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boletines_Personas_PersonaId",
                table: "Boletines");

            migrationBuilder.DropIndex(
                name: "IX_Boletines_PersonaId",
                table: "Boletines");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_BoletinId",
                table: "Personas",
                column: "BoletinId",
                unique: true,
                filter: "[BoletinId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Boletines_BoletinId",
                table: "Personas",
                column: "BoletinId",
                principalTable: "Boletines",
                principalColumn: "BoletinId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
