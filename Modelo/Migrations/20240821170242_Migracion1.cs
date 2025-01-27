using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiclosAcademicos",
                columns: table => new
                {
                    CicloAcademicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Año = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiclosAcademicos", x => x.CicloAcademicoId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosFinales",
                columns: table => new
                {
                    EstadoFinalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosFinales", x => x.EstadoFinalId);
                });

            migrationBuilder.CreateTable(
                name: "Sexos",
                columns: table => new
                {
                    SexoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexos", x => x.SexoId);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeAsistencias",
                columns: table => new
                {
                    TipoDeAsistenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeAsistencias", x => x.TipoDeAsistenciaId);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeCiclos",
                columns: table => new
                {
                    TipoDeCicloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeCiclos", x => x.TipoDeCicloId);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeExamenes",
                columns: table => new
                {
                    TipoDeExamenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeExamenes", x => x.TipoDeExamenId);
                });

            migrationBuilder.CreateTable(
                name: "Trimestres",
                columns: table => new
                {
                    TrimestreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumTrimestre = table.Column<int>(type: "int", nullable: false),
                    DiasTotalesHabiles = table.Column<int>(type: "int", nullable: false),
                    CicloAcademicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trimestres", x => x.TrimestreId);
                    table.ForeignKey(
                        name: "FK_Trimestres_CiclosAcademicos_CicloAcademicoId",
                        column: x => x.CicloAcademicoId,
                        principalTable: "CiclosAcademicos",
                        principalColumn: "CicloAcademicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boletines",
                columns: table => new
                {
                    BoletinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromedioTrimestre1 = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    PromedioTrimestre2 = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    PromedioTrimestre3 = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    ObservacionTrimestre1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservacionTrimestre2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservacionTrimestre3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    LibroDeNotasId = table.Column<int>(type: "int", nullable: false),
                    LibroDeAsistenciasId = table.Column<int>(type: "int", nullable: false),
                    EstadoFinalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletines", x => x.BoletinId);
                    table.ForeignKey(
                        name: "FK_Boletines_EstadosFinales_EstadoFinalId",
                        column: x => x.EstadoFinalId,
                        principalTable: "EstadosFinales",
                        principalColumn: "EstadoFinalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GradosAcademicos",
                columns: table => new
                {
                    GradoAcademicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumGrado = table.Column<int>(type: "int", nullable: false),
                    CantDeMaterias = table.Column<int>(type: "int", nullable: false),
                    TipoDeCicloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradosAcademicos", x => x.GradoAcademicoId);
                    table.ForeignKey(
                        name: "FK_GradosAcademicos_TiposDeCiclos_TipoDeCicloId",
                        column: x => x.TipoDeCicloId,
                        principalTable: "TiposDeCiclos",
                        principalColumn: "TipoDeCicloId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibrosDeAsistencias",
                columns: table => new
                {
                    LibroDeAsistenciasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoletinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibrosDeAsistencias", x => x.LibroDeAsistenciasId);
                    table.ForeignKey(
                        name: "FK_LibrosDeAsistencias_Boletines_BoletinId",
                        column: x => x.BoletinId,
                        principalTable: "Boletines",
                        principalColumn: "BoletinId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibrosDeNotas",
                columns: table => new
                {
                    LibroDeNotasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoletinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibrosDeNotas", x => x.LibroDeNotasId);
                    table.ForeignKey(
                        name: "FK_LibrosDeNotas_Boletines_BoletinId",
                        column: x => x.BoletinId,
                        principalTable: "Boletines",
                        principalColumn: "BoletinId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    MateriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradoAcademicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.MateriaId);
                    table.ForeignKey(
                        name: "FK_Materias_GradosAcademicos_GradoAcademicoId",
                        column: x => x.GradoAcademicoId,
                        principalTable: "GradosAcademicos",
                        principalColumn: "GradoAcademicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPostal = table.Column<int>(type: "int", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SexoId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    BoletinId = table.Column<int>(type: "int", nullable: true),
                    CicloAcademicoId = table.Column<int>(type: "int", nullable: true),
                    GradoAcademicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                    table.ForeignKey(
                        name: "FK_Personas_Boletines_BoletinId",
                        column: x => x.BoletinId,
                        principalTable: "Boletines",
                        principalColumn: "BoletinId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_CiclosAcademicos_CicloAcademicoId",
                        column: x => x.CicloAcademicoId,
                        principalTable: "CiclosAcademicos",
                        principalColumn: "CicloAcademicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_GradosAcademicos_GradoAcademicoId",
                        column: x => x.GradoAcademicoId,
                        principalTable: "GradosAcademicos",
                        principalColumn: "GradoAcademicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Sexos_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexos",
                        principalColumn: "SexoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    AsistenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumTrimestre = table.Column<int>(type: "int", nullable: false),
                    LibroDeAsistenciasId = table.Column<int>(type: "int", nullable: false),
                    TipoDeAsistenciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.AsistenciaId);
                    table.ForeignKey(
                        name: "FK_Asistencias_LibrosDeAsistencias_LibroDeAsistenciasId",
                        column: x => x.LibroDeAsistenciasId,
                        principalTable: "LibrosDeAsistencias",
                        principalColumn: "LibroDeAsistenciasId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asistencias_TiposDeAsistencias_TipoDeAsistenciaId",
                        column: x => x.TipoDeAsistenciaId,
                        principalTable: "TiposDeAsistencias",
                        principalColumn: "TipoDeAsistenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Examenes",
                columns: table => new
                {
                    ExamenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumTrimestre = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    LibroDeNotasId = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    TipoDeExamenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examenes", x => x.ExamenId);
                    table.ForeignKey(
                        name: "FK_Examenes_LibrosDeNotas_LibroDeNotasId",
                        column: x => x.LibroDeNotasId,
                        principalTable: "LibrosDeNotas",
                        principalColumn: "LibroDeNotasId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Examenes_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "MateriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Examenes_TiposDeExamenes_TipoDeExamenId",
                        column: x => x.TipoDeExamenId,
                        principalTable: "TiposDeExamenes",
                        principalColumn: "TipoDeExamenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EstadosFinales",
                columns: new[] { "EstadoFinalId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "A01", "Aprobado" },
                    { 2, "A02", "Reprobado" },
                    { 3, "A03", "Mes de recuperación" }
                });

            migrationBuilder.InsertData(
                table: "TiposDeAsistencias",
                columns: new[] { "TipoDeAsistenciaId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "A01", "Presente" },
                    { 2, "A02", "Ausente" },
                    { 3, "A03", "Falta justificada" },
                    { 4, "A04", "Retiro" }
                });

            migrationBuilder.InsertData(
                table: "TiposDeCiclos",
                columns: new[] { "TipoDeCicloId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "A01", "Ciclo Basico" },
                    { 2, "A02", "Ciclo Superior" }
                });

            migrationBuilder.InsertData(
                table: "TiposDeExamenes",
                columns: new[] { "TipoDeExamenId", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "A01", "Parcial" },
                    { 2, "A02", "Recuperatorio" }
                });

            migrationBuilder.InsertData(
                table: "GradosAcademicos",
                columns: new[] { "GradoAcademicoId", "CantDeMaterias", "NumGrado", "TipoDeCicloId" },
                values: new object[,]
                {
                    { 1, 8, 1, 1 },
                    { 2, 10, 2, 1 },
                    { 3, 10, 3, 1 },
                    { 4, 11, 4, 2 },
                    { 5, 11, 5, 2 },
                    { 6, 10, 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "CodigoMateria", "GradoAcademicoId", "NombreMateria" },
                values: new object[,]
                {
                    { 1, "A01", 1, "Ciencias Naturales" },
                    { 2, "A02", 1, "Ciencias Sociales" },
                    { 3, "A03", 1, "Educación Artística" },
                    { 4, "A04", 1, "Educación Física" },
                    { 5, "A05", 1, "Inglés" },
                    { 6, "A06", 1, "Matemática" },
                    { 7, "A07", 1, "Prácticas del Lenguaje" },
                    { 8, "A08", 1, "Construcción de Ciudadanía" },
                    { 9, "B01", 2, "Biología" },
                    { 10, "B02", 2, "Construcción de Ciudadanía" },
                    { 11, "B03", 2, "Educación Artística" },
                    { 12, "B04", 2, "Educación Física" },
                    { 13, "B05", 2, "Físico Química" },
                    { 14, "B06", 2, "Geografía" },
                    { 15, "B07", 2, "Historia" },
                    { 16, "B08", 2, "Inglés" },
                    { 17, "B09", 2, "Matemática" },
                    { 18, "B10", 2, "Prácticas del Lenguaje" },
                    { 19, "C01", 3, "Biología" },
                    { 20, "C02", 3, "Construcción de Ciudadanía" },
                    { 21, "C03", 3, "Educación Artística" },
                    { 22, "C04", 3, "Educación Física" },
                    { 23, "C05", 3, "Físico Química" },
                    { 24, "C06", 3, "Geografía" },
                    { 25, "C07", 3, "Historia" },
                    { 26, "C08", 3, "Inglés" },
                    { 27, "C09", 3, "Matemática" },
                    { 28, "C10", 3, "Prácticas del Lenguaje" },
                    { 29, "D01", 4, "Matemática" },
                    { 30, "D02", 4, "Literatura" },
                    { 31, "D03", 4, "Educación Física" },
                    { 32, "D04", 4, "Inglés" },
                    { 33, "D05", 4, "Salud y Adolescencia" },
                    { 34, "D06", 4, "Biología" },
                    { 35, "D07", 4, "Historia" },
                    { 36, "D08", 4, "Geografía" },
                    { 37, "D09", 4, "NTICx" },
                    { 38, "D10", 4, "Psicología" },
                    { 39, "E01", 5, "Matemática" },
                    { 40, "E02", 5, "Literatura" },
                    { 41, "E03", 5, "Educación Física" },
                    { 42, "E04", 5, "Inglés" },
                    { 43, "E05", 5, "Política y Ciudadanía" },
                    { 44, "E06", 5, "Introducción a la Química" },
                    { 45, "E07", 5, "Comunicación, Cultura y Sociedad" },
                    { 46, "E08", 5, "Historia" },
                    { 47, "E09", 5, "Geografía" },
                    { 48, "E10", 5, "Economía Política" },
                    { 49, "E11", 5, "Sociología" },
                    { 50, "F01", 6, "Matemática" },
                    { 51, "F02", 6, "Literatura" },
                    { 52, "F03", 6, "Educación Física" },
                    { 53, "F04", 6, "Inglés" },
                    { 54, "F05", 6, "Trabajo y Ciudadanía" },
                    { 55, "F06", 6, "Proyecto de Investigación en Ciencias Sociales" },
                    { 56, "F07", 6, "Historia" },
                    { 57, "F08", 6, "Geografía" },
                    { 58, "F09", 6, "Arte" },
                    { 59, "F10", 6, "Filosofía" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_LibroDeAsistenciasId",
                table: "Asistencias",
                column: "LibroDeAsistenciasId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_TipoDeAsistenciaId",
                table: "Asistencias",
                column: "TipoDeAsistenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletines_EstadoFinalId",
                table: "Boletines",
                column: "EstadoFinalId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_LibroDeNotasId",
                table: "Examenes",
                column: "LibroDeNotasId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_MateriaId",
                table: "Examenes",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_TipoDeExamenId",
                table: "Examenes",
                column: "TipoDeExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_GradosAcademicos_TipoDeCicloId",
                table: "GradosAcademicos",
                column: "TipoDeCicloId");

            migrationBuilder.CreateIndex(
                name: "IX_LibrosDeAsistencias_BoletinId",
                table: "LibrosDeAsistencias",
                column: "BoletinId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibrosDeNotas_BoletinId",
                table: "LibrosDeNotas",
                column: "BoletinId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materias_GradoAcademicoId",
                table: "Materias",
                column: "GradoAcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_BoletinId",
                table: "Personas",
                column: "BoletinId",
                unique: true,
                filter: "[BoletinId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CicloAcademicoId",
                table: "Personas",
                column: "CicloAcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_GradoAcademicoId",
                table: "Personas",
                column: "GradoAcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_SexoId",
                table: "Personas",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Trimestres_CicloAcademicoId",
                table: "Trimestres",
                column: "CicloAcademicoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "Examenes");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Trimestres");

            migrationBuilder.DropTable(
                name: "LibrosDeAsistencias");

            migrationBuilder.DropTable(
                name: "TiposDeAsistencias");

            migrationBuilder.DropTable(
                name: "LibrosDeNotas");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "TiposDeExamenes");

            migrationBuilder.DropTable(
                name: "Sexos");

            migrationBuilder.DropTable(
                name: "CiclosAcademicos");

            migrationBuilder.DropTable(
                name: "Boletines");

            migrationBuilder.DropTable(
                name: "GradosAcademicos");

            migrationBuilder.DropTable(
                name: "EstadosFinales");

            migrationBuilder.DropTable(
                name: "TiposDeCiclos");
        }
    }
}
