using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoDePago_TiposDeTarjeta_TipoDeTarjetaId",
                table: "TipoDePago");

            migrationBuilder.DropTable(
                name: "TiposDeTarjeta");

            migrationBuilder.DropIndex(
                name: "IX_TipoDePago_TipoDeTarjetaId",
                table: "TipoDePago");

            migrationBuilder.DropColumn(
                name: "CantidadEntregada",
                table: "TipoDePago");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "TipoDePago");

            migrationBuilder.DropColumn(
                name: "NumDeComprobante",
                table: "TipoDePago");

            migrationBuilder.DropColumn(
                name: "NumDeTransferencia",
                table: "TipoDePago");

            migrationBuilder.DropColumn(
                name: "TipoDeTarjetaId",
                table: "TipoDePago");

            migrationBuilder.DropColumn(
                name: "Vuelto",
                table: "TipoDePago");

            migrationBuilder.AddColumn<string>(
                name: "CodigoDeComprobante",
                table: "Pagos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "TipoDePago",
                columns: new[] { "TipoDePagoId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "A1", "Transferencia" },
                    { 2, "A2", "Débito" },
                    { 3, "A3", "Crédito" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoDePago",
                keyColumn: "TipoDePagoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoDePago",
                keyColumn: "TipoDePagoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoDePago",
                keyColumn: "TipoDePagoId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CodigoDeComprobante",
                table: "Pagos");

            migrationBuilder.AddColumn<decimal>(
                name: "CantidadEntregada",
                table: "TipoDePago",
                type: "decimal(4,1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "TipoDePago",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumDeComprobante",
                table: "TipoDePago",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumDeTransferencia",
                table: "TipoDePago",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoDeTarjetaId",
                table: "TipoDePago",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Vuelto",
                table: "TipoDePago",
                type: "decimal(4,1)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TiposDeTarjeta",
                columns: table => new
                {
                    TipoDeTarjetaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeTarjeta", x => x.TipoDeTarjetaId);
                });

            migrationBuilder.InsertData(
                table: "TiposDeTarjeta",
                columns: new[] { "TipoDeTarjetaId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "A1", "Débito" },
                    { 2, "A2", "Crédito" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoDePago_TipoDeTarjetaId",
                table: "TipoDePago",
                column: "TipoDeTarjetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoDePago_TiposDeTarjeta_TipoDeTarjetaId",
                table: "TipoDePago",
                column: "TipoDeTarjetaId",
                principalTable: "TiposDeTarjeta",
                principalColumn: "TipoDeTarjetaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
