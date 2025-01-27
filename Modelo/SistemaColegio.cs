using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SistemaColegio : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Boletin> Boletines { get; set; }
        public DbSet<CicloAcademico> CiclosAcademicos { get; set; }
        public DbSet<EstadoFinal> EstadosFinales { get; set; }
        public DbSet<Examen> Examenes { get; set; }
        public DbSet<GradoAcademico> GradosAcademicos { get; set; }
        public DbSet<LibroDeAsistencias> LibrosDeAsistencias { get; set; }
        public DbSet<LibroDeNotas> LibrosDeNotas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<TipoDeAsistencia> TiposDeAsistencias { get; set; }
        public DbSet<TipoDeCiclo> TiposDeCiclos { get; set; }
        public DbSet<TipoDeExamen> TiposDeExamenes { get; set; }
        public DbSet<Trimestre> Trimestres { get; set; }
        public DbSet<Cuota> Cuotas { get; set; }
        public DbSet<PagoDeCuota> PagosDeCuota { get; set; }
        public DbSet<EstadoCuota> EstadosCuota { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<TipoDePago> TiposDePagos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Opcion> Opciones { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<RolUsuario> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BD_EduControl1;
        Integrated Security=True;MultipleActiveResultSets=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Boletin>()
                .Property(l => l.PromedioTrimestre1)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<Boletin>()
                .Property(l => l.PromedioTrimestre2)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<Boletin>()
                .Property(l => l.PromedioTrimestre3)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<Examen>()
                .Property(l => l.Nota)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<Boletin>()
                .Property(l => l.PromedioAsistenciaTrimestre1)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<Boletin>()
                .Property(l => l.PromedioAsistenciaTrimestre2)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<Boletin>()
                .Property(l => l.PromedioAsistenciaTrimestre3)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<Boletin>()
                .Property(l => l.PromedioTotalExamenes)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<Boletin>()
                .Property(l => l.PromedioTotalAsistencia)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<Cuota>()
                .Property(c => c.Precio)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<PagoDeCuota>()
                .Property(p => p.MontoFinal)
                .HasColumnType("decimal(4, 1)");

            //Relacion de Asistencia con TipoDeAsistencia
            modelBuilder.Entity<Asistencia>()
                .HasOne(a => a.TipoDeAsistencia)    // Una Asistencia tiene un TipoDeAsistencia
                .WithMany(t => t.Asistencias)       // Un TipoDeAsistencia tiene muchas Asistencias
                .HasForeignKey(a => a.TipoDeAsistenciaId);  // Clave foránea en Asistencia

            modelBuilder.Entity<Asistencia>()
                .HasOne(a => a.LibroDeAsistencias)    // Una Asistencia tiene un LibroDeAsistencias
                .WithMany(l => l.Asistencias)         // Un LibroDeAsistencias tiene muchas Asistencias
                .HasForeignKey(a => a.LibroDeAsistenciasId); // Clave foránea en Asistencia


            //Relacion de Boletin con LibroDeAsistencias
            modelBuilder.Entity<Boletin>()
                .HasOne(b => b.LibroDeAsistencias)
                .WithOne(la => la.Boletin)
                .HasForeignKey<LibroDeAsistencias>(la => la.BoletinId); // Clave foránea en LibroDeAsistencias

            //Relación uno a uno entre Boletin y LibroDeNotas
            modelBuilder.Entity<Boletin>()
                .HasOne(b => b.LibroDeNotas) // Un Boletin tiene un LibroDeNotas
                .WithOne(ln => ln.Boletin)   // Un LibroDeNotas tiene un Boletin
                .HasForeignKey<LibroDeNotas>(ln => ln.BoletinId); // Clave foránea en LibroDeNotas

            // Relación uno a muchos entre Alumno y Boletin
            modelBuilder.Entity<Boletin>()
                .HasOne(b => b.Alumno)  // Un Boletin tiene un Alumno
                .WithMany(a => a.Boletines)  // Un Alumno tiene muchos Boletines
                .HasForeignKey(b => b.PersonaId) // Clave foránea en Boletin
                .OnDelete(DeleteBehavior.Restrict); // Cambia el comportamiento de eliminación

            modelBuilder.Entity<TipoDeCiclo>().HasData(
                new TipoDeCiclo { TipoDeCicloId = 1, Codigo = "A01", Nombre = "Ciclo Basico" },
                new TipoDeCiclo { TipoDeCicloId = 2, Codigo = "A02", Nombre = "Ciclo Superior" }
            );

            //Relacion de PagoDeCuota con EstadoCuota
            modelBuilder.Entity<PagoDeCuota>()
                .HasOne(p => p.EstadoCuota)    // Un PagoDeCuota tiene un EstadoCuota
                .WithMany(e => e.PagosDeCuota)       // Un EstadoCuota tiene muchos PagosDeCuota
                .HasForeignKey(p => p.EstadoCuotaId);  // Clave foránea en PagoDeCuota


            //Relacion de Pago con TipoDePago
            modelBuilder.Entity<Pago>()
                .HasOne(p => p.TipoDePago)    // Un Pago tiene un TipoDePago.
                .WithMany(t => t.Pagos)       // Un TipoDePago tiene muchas Pagos.
                .HasForeignKey(t => t.TipoDePagoId);  // Clave foránea en Pago.

            modelBuilder.Entity<PagoDeCuota>()     // Configura la entidad PagosDeCuota en el modelo de Entity Framework.
                .HasOne(p => p.Alumno)             // Especifica que PagosDeCuota tiene una relación de uno-a-uno o uno-a-muchos con la entidad Persona.
                .WithMany()                        // Define que la entidad Persona puede tener múltiples registros asociados en PagosDeCuota.
                .HasForeignKey(p => p.AlumnoId)    // Configura AlumnoId como la clave foránea en PagosDeCuota que hace referencia a Persona.
                .OnDelete(DeleteBehavior.NoAction);// Establece que, en caso de eliminar una Persona, no se eliminen automáticamente los registros en PagosDeCuota.

            // Configurar la relación entre Usuario y RolUsuario
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.RolUsuario) // Cada usuario tiene un RolUsuario
                .WithMany(r => r.Usuario) // Un rol tiene muchos usuarios
                .HasForeignKey(u => u.RolId) // La clave foránea es RolId
                .OnDelete(DeleteBehavior.Restrict); // Evitar eliminación en cascada

            /*
            modelBuilder.Entity<Modulo>()
                .HasKey(m => m.IdModulo); // Configura IdModulo como clave primaria
            */

            // Datos iniciales para la entidad GradoAcademico.
            modelBuilder.Entity<GradoAcademico>().HasData(
                new GradoAcademico { GradoAcademicoId = 1, NumGrado = 1, CantDeMaterias = 8, TipoDeCicloId = 1 },
                new GradoAcademico { GradoAcademicoId = 2, NumGrado = 2, CantDeMaterias = 10, TipoDeCicloId = 1 },
                new GradoAcademico { GradoAcademicoId = 3, NumGrado = 3, CantDeMaterias = 10, TipoDeCicloId = 1 },
                new GradoAcademico { GradoAcademicoId = 4, NumGrado = 4, CantDeMaterias = 11, TipoDeCicloId = 2 },
                new GradoAcademico { GradoAcademicoId = 5, NumGrado = 5, CantDeMaterias = 11, TipoDeCicloId = 2 },
                new GradoAcademico { GradoAcademicoId = 6, NumGrado = 6, CantDeMaterias = 10, TipoDeCicloId = 2 }
            );

            // Datos iniciales para la entidad Materia
            modelBuilder.Entity<Materia>().HasData(
                new Materia { MateriaId = 1, CodigoMateria = "A01", NombreMateria = "Ciencias Naturales", GradoAcademicoId = 1 },
                new Materia { MateriaId = 2, CodigoMateria = "A02", NombreMateria = "Ciencias Sociales", GradoAcademicoId = 1 },
                new Materia { MateriaId = 3, CodigoMateria = "A03", NombreMateria = "Educación Artística", GradoAcademicoId = 1 },
                new Materia { MateriaId = 4, CodigoMateria = "A04", NombreMateria = "Educación Física", GradoAcademicoId = 1 },
                new Materia { MateriaId = 5, CodigoMateria = "A05", NombreMateria = "Inglés", GradoAcademicoId = 1 },
                new Materia { MateriaId = 6, CodigoMateria = "A06", NombreMateria = "Matemática", GradoAcademicoId = 1 },
                new Materia { MateriaId = 7, CodigoMateria = "A07", NombreMateria = "Prácticas del Lenguaje", GradoAcademicoId = 1 },
                new Materia { MateriaId = 8, CodigoMateria = "A08", NombreMateria = "Construcción de Ciudadanía", GradoAcademicoId = 1 },


                new Materia { MateriaId = 9, CodigoMateria = "B01", NombreMateria = "Biología", GradoAcademicoId = 2 },
                new Materia { MateriaId = 10, CodigoMateria = "B02", NombreMateria = "Construcción de Ciudadanía", GradoAcademicoId = 2 },
                new Materia { MateriaId = 11, CodigoMateria = "B03", NombreMateria = "Educación Artística", GradoAcademicoId = 2 },
                new Materia { MateriaId = 12, CodigoMateria = "B04", NombreMateria = "Educación Física", GradoAcademicoId = 2 },
                new Materia { MateriaId = 13, CodigoMateria = "B05", NombreMateria = "Físico Química", GradoAcademicoId = 2 },
                new Materia { MateriaId = 14, CodigoMateria = "B06", NombreMateria = "Geografía", GradoAcademicoId = 2 },
                new Materia { MateriaId = 15, CodigoMateria = "B07", NombreMateria = "Historia", GradoAcademicoId = 2 },
                new Materia { MateriaId = 16, CodigoMateria = "B08", NombreMateria = "Inglés", GradoAcademicoId = 2 },
                new Materia { MateriaId = 17, CodigoMateria = "B09", NombreMateria = "Matemática", GradoAcademicoId = 2 },
                new Materia { MateriaId = 18, CodigoMateria = "B10", NombreMateria = "Prácticas del Lenguaje", GradoAcademicoId = 2 },


                new Materia { MateriaId = 19, CodigoMateria = "C01", NombreMateria = "Biología", GradoAcademicoId = 3 },
                new Materia { MateriaId = 20, CodigoMateria = "C02", NombreMateria = "Construcción de Ciudadanía", GradoAcademicoId = 3 },
                new Materia { MateriaId = 21, CodigoMateria = "C03", NombreMateria = "Educación Artística", GradoAcademicoId = 3 },
                new Materia { MateriaId = 22, CodigoMateria = "C04", NombreMateria = "Educación Física", GradoAcademicoId = 3 },
                new Materia { MateriaId = 23, CodigoMateria = "C05", NombreMateria = "Físico Química", GradoAcademicoId = 3 },
                new Materia { MateriaId = 24, CodigoMateria = "C06", NombreMateria = "Geografía", GradoAcademicoId = 3 },
                new Materia { MateriaId = 25, CodigoMateria = "C07", NombreMateria = "Historia", GradoAcademicoId = 3 },
                new Materia { MateriaId = 26, CodigoMateria = "C08", NombreMateria = "Inglés", GradoAcademicoId = 3 },
                new Materia { MateriaId = 27, CodigoMateria = "C09", NombreMateria = "Matemática", GradoAcademicoId = 3 },
                new Materia { MateriaId = 28, CodigoMateria = "C10", NombreMateria = "Prácticas del Lenguaje", GradoAcademicoId = 3 },


                new Materia { MateriaId = 29, CodigoMateria = "D01", NombreMateria = "Matemática", GradoAcademicoId = 4 },
                new Materia { MateriaId = 30, CodigoMateria = "D02", NombreMateria = "Literatura", GradoAcademicoId = 4 },
                new Materia { MateriaId = 31, CodigoMateria = "D03", NombreMateria = "Educación Física", GradoAcademicoId = 4 },
                new Materia { MateriaId = 32, CodigoMateria = "D04", NombreMateria = "Inglés", GradoAcademicoId = 4 },
                new Materia { MateriaId = 33, CodigoMateria = "D05", NombreMateria = "Salud y Adolescencia", GradoAcademicoId = 4 },
                new Materia { MateriaId = 34, CodigoMateria = "D06", NombreMateria = "Biología", GradoAcademicoId = 4 },
                new Materia { MateriaId = 35, CodigoMateria = "D07", NombreMateria = "Historia", GradoAcademicoId = 4 },
                new Materia { MateriaId = 36, CodigoMateria = "D08", NombreMateria = "Geografía", GradoAcademicoId = 4 },
                new Materia { MateriaId = 37, CodigoMateria = "D09", NombreMateria = "NTICx", GradoAcademicoId = 4 },
                new Materia { MateriaId = 38, CodigoMateria = "D10", NombreMateria = "Psicología", GradoAcademicoId = 4 },


                new Materia { MateriaId = 39, CodigoMateria = "E01", NombreMateria = "Matemática", GradoAcademicoId = 5 },
                new Materia { MateriaId = 40, CodigoMateria = "E02", NombreMateria = "Literatura", GradoAcademicoId = 5 },
                new Materia { MateriaId = 41, CodigoMateria = "E03", NombreMateria = "Educación Física", GradoAcademicoId = 5 },
                new Materia { MateriaId = 42, CodigoMateria = "E04", NombreMateria = "Inglés", GradoAcademicoId = 5 },
                new Materia { MateriaId = 43, CodigoMateria = "E05", NombreMateria = "Política y Ciudadanía", GradoAcademicoId = 5 },
                new Materia { MateriaId = 44, CodigoMateria = "E06", NombreMateria = "Introducción a la Química", GradoAcademicoId = 5 },
                new Materia { MateriaId = 45, CodigoMateria = "E07", NombreMateria = "Comunicación, Cultura y Sociedad", GradoAcademicoId = 5 },
                new Materia { MateriaId = 46, CodigoMateria = "E08", NombreMateria = "Historia", GradoAcademicoId = 5 },
                new Materia { MateriaId = 47, CodigoMateria = "E09", NombreMateria = "Geografía", GradoAcademicoId = 5 },
                new Materia { MateriaId = 48, CodigoMateria = "E10", NombreMateria = "Economía Política", GradoAcademicoId = 5 },
                new Materia { MateriaId = 49, CodigoMateria = "E11", NombreMateria = "Sociología", GradoAcademicoId = 5 },


                new Materia { MateriaId = 50, CodigoMateria = "F01", NombreMateria = "Matemática", GradoAcademicoId = 6 },
                new Materia { MateriaId = 51, CodigoMateria = "F02", NombreMateria = "Literatura", GradoAcademicoId = 6 },
                new Materia { MateriaId = 52, CodigoMateria = "F03", NombreMateria = "Educación Física", GradoAcademicoId = 6 },
                new Materia { MateriaId = 53, CodigoMateria = "F04", NombreMateria = "Inglés", GradoAcademicoId = 6 },
                new Materia { MateriaId = 54, CodigoMateria = "F05", NombreMateria = "Trabajo y Ciudadanía", GradoAcademicoId = 6 },
                new Materia { MateriaId = 55, CodigoMateria = "F06", NombreMateria = "Proyecto de Investigación en Ciencias Sociales", GradoAcademicoId = 6 },
                new Materia { MateriaId = 56, CodigoMateria = "F07", NombreMateria = "Historia", GradoAcademicoId = 6 },
                new Materia { MateriaId = 57, CodigoMateria = "F08", NombreMateria = "Geografía", GradoAcademicoId = 6 },
                new Materia { MateriaId = 58, CodigoMateria = "F09", NombreMateria = "Arte", GradoAcademicoId = 6 },
                new Materia { MateriaId = 59, CodigoMateria = "F10", NombreMateria = "Filosofía", GradoAcademicoId = 6 }
            );

            modelBuilder.Entity<EstadoFinal>().HasData(
                new EstadoFinal { EstadoFinalId = 1, Codigo = "A01", Nombre = "Aprobado" },
                new EstadoFinal { EstadoFinalId = 2, Codigo = "A02", Nombre = "Reprobado" },
                new EstadoFinal { EstadoFinalId = 3, Codigo = "A03", Nombre = "Mes de recuperación" }
            );

            modelBuilder.Entity<TipoDeAsistencia>().HasData(
                new TipoDeAsistencia { TipoDeAsistenciaId = 1, Codigo = "A01", Nombre = "Presente" },
                new TipoDeAsistencia { TipoDeAsistenciaId = 2, Codigo = "A02", Nombre = "Ausente" },
                new TipoDeAsistencia { TipoDeAsistenciaId = 3, Codigo = "A03", Nombre = "Falta justificada" },
                new TipoDeAsistencia { TipoDeAsistenciaId = 4, Codigo = "A04", Nombre = "Retiro" }
            );

            modelBuilder.Entity<TipoDeExamen>().HasData(
                new TipoDeExamen { TipoDeExamenId = 1, Codigo = "A01", Nombre = "Parcial" },
                new TipoDeExamen { TipoDeExamenId = 2, Codigo = "A02", Nombre = "Recuperatorio" }
            );

            modelBuilder.Entity<Sexo>().HasData(
                new Sexo { SexoId = 1, Codigo = "A1", Nombre = "Masculino" },
                new Sexo { SexoId = 2, Codigo = "A2", Nombre = "Femenino" }
            );

            modelBuilder.Entity<EstadoCuota>().HasData(
                new EstadoCuota { EstadoCuotaId = 1, Codigo = "A1", Nombre = "Cuota paga" },
                new EstadoCuota { EstadoCuotaId = 2, Codigo = "A2", Nombre = "Cuota impaga" }
            );

            modelBuilder.Entity<TipoDePago>().HasData(
                new TipoDePago { TipoDePagoId = 1, Codigo = "A1", Nombre = "Transferencia" },
                new TipoDePago { TipoDePagoId = 2, Codigo = "A2", Nombre = "Débito" },
                new TipoDePago { TipoDePagoId = 3, Codigo = "A3", Nombre = "Crédito" }
            );
        }
    }
}
