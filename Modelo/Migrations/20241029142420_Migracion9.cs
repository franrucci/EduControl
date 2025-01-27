using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuotas",
                columns: table => new
                {
                    CuotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CicloAcademicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuotas", x => x.CuotaId);
                    table.ForeignKey(
                        name: "FK_Cuotas_CiclosAcademicos_CicloAcademicoId",
                        column: x => x.CicloAcademicoId,
                        principalTable: "CiclosAcademicos",
                        principalColumn: "CicloAcademicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstadosCuota",
                columns: table => new
                {
                    EstadoCuotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosCuota", x => x.EstadoCuotaId);
                });

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

            migrationBuilder.CreateTable(
                name: "TipoDePago",
                columns: table => new
                {
                    TipoDePagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    CantidadEntregada = table.Column<decimal>(type: "decimal(4,1)", nullable: true),
                    Vuelto = table.Column<decimal>(type: "decimal(4,1)", nullable: true),
                    NumDeComprobante = table.Column<int>(type: "int", nullable: true),
                    TipoDeTarjetaId = table.Column<int>(type: "int", nullable: true),
                    NumDeTransferencia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDePago", x => x.TipoDePagoId);
                    table.ForeignKey(
                        name: "FK_TipoDePago_TiposDeTarjeta_TipoDeTarjetaId",
                        column: x => x.TipoDeTarjetaId,
                        principalTable: "TiposDeTarjeta",
                        principalColumn: "TipoDeTarjetaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePagador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoPagador = table.Column<int>(type: "int", nullable: false),
                    DniPagador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDePagoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagoId);
                    table.ForeignKey(
                        name: "FK_Pagos_TipoDePago_TipoDePagoId",
                        column: x => x.TipoDePagoId,
                        principalTable: "TipoDePago",
                        principalColumn: "TipoDePagoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagosDeCuota",
                columns: table => new
                {
                    PagoDeCuotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CuotaId = table.Column<int>(type: "int", nullable: false),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    EstadoCuotaId = table.Column<int>(type: "int", nullable: false),
                    PagoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagosDeCuota", x => x.PagoDeCuotaId);
                    table.ForeignKey(
                        name: "FK_PagosDeCuota_Cuotas_CuotaId",
                        column: x => x.CuotaId,
                        principalTable: "Cuotas",
                        principalColumn: "CuotaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagosDeCuota_EstadosCuota_EstadoCuotaId",
                        column: x => x.EstadoCuotaId,
                        principalTable: "EstadosCuota",
                        principalColumn: "EstadoCuotaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagosDeCuota_Pagos_PagoId",
                        column: x => x.PagoId,
                        principalTable: "Pagos",
                        principalColumn: "PagoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagosDeCuota_Personas_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                });

            migrationBuilder.InsertData(
                table: "EstadosCuota",
                columns: new[] { "EstadoCuotaId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "A1", "Cuota paga" },
                    { 2, "A2", "Cuota impaga" }
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
                name: "IX_Cuotas_CicloAcademicoId",
                table: "Cuotas",
                column: "CicloAcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_TipoDePagoId",
                table: "Pagos",
                column: "TipoDePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeCuota_AlumnoId",
                table: "PagosDeCuota",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeCuota_CuotaId",
                table: "PagosDeCuota",
                column: "CuotaId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeCuota_EstadoCuotaId",
                table: "PagosDeCuota",
                column: "EstadoCuotaId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeCuota_PagoId",
                table: "PagosDeCuota",
                column: "PagoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoDePago_TipoDeTarjetaId",
                table: "TipoDePago",
                column: "TipoDeTarjetaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PagosDeCuota");

            migrationBuilder.DropTable(
                name: "Cuotas");

            migrationBuilder.DropTable(
                name: "EstadosCuota");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "TipoDePago");

            migrationBuilder.DropTable(
                name: "TiposDeTarjeta");
        }
    }
}
