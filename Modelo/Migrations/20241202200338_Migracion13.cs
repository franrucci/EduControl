using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_TipoDePago_TipoDePagoId",
                table: "Pagos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoDePago",
                table: "TipoDePago");

            migrationBuilder.RenameTable(
                name: "TipoDePago",
                newName: "TiposDePagos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposDePagos",
                table: "TiposDePagos",
                column: "TipoDePagoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_TiposDePagos_TipoDePagoId",
                table: "Pagos",
                column: "TipoDePagoId",
                principalTable: "TiposDePagos",
                principalColumn: "TipoDePagoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_TiposDePagos_TipoDePagoId",
                table: "Pagos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposDePagos",
                table: "TiposDePagos");

            migrationBuilder.RenameTable(
                name: "TiposDePagos",
                newName: "TipoDePago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoDePago",
                table: "TipoDePago",
                column: "TipoDePagoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_TipoDePago_TipoDePagoId",
                table: "Pagos",
                column: "TipoDePagoId",
                principalTable: "TipoDePago",
                principalColumn: "TipoDePagoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
