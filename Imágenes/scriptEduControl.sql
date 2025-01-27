IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [CiclosAcademicos] (
        [CicloAcademicoId] int NOT NULL IDENTITY,
        [Año] int NOT NULL,
        CONSTRAINT [PK_CiclosAcademicos] PRIMARY KEY ([CicloAcademicoId])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [EstadosFinales] (
        [EstadoFinalId] int NOT NULL IDENTITY,
        [Codigo] nvarchar(max) NOT NULL,
        [Nombre] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_EstadosFinales] PRIMARY KEY ([EstadoFinalId])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [Sexos] (
        [SexoId] int NOT NULL IDENTITY,
        [Codigo] nvarchar(max) NOT NULL,
        [Nombre] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Sexos] PRIMARY KEY ([SexoId])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [TiposDeAsistencias] (
        [TipoDeAsistenciaId] int NOT NULL IDENTITY,
        [Codigo] nvarchar(max) NOT NULL,
        [Nombre] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_TiposDeAsistencias] PRIMARY KEY ([TipoDeAsistenciaId])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [TiposDeCiclos] (
        [TipoDeCicloId] int NOT NULL IDENTITY,
        [Codigo] nvarchar(max) NOT NULL,
        [Nombre] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_TiposDeCiclos] PRIMARY KEY ([TipoDeCicloId])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [TiposDeExamenes] (
        [TipoDeExamenId] int NOT NULL IDENTITY,
        [Codigo] nvarchar(max) NOT NULL,
        [Nombre] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_TiposDeExamenes] PRIMARY KEY ([TipoDeExamenId])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [Trimestres] (
        [TrimestreId] int NOT NULL IDENTITY,
        [NumTrimestre] int NOT NULL,
        [DiasTotalesHabiles] int NOT NULL,
        [CicloAcademicoId] int NOT NULL,
        CONSTRAINT [PK_Trimestres] PRIMARY KEY ([TrimestreId]),
        CONSTRAINT [FK_Trimestres_CiclosAcademicos_CicloAcademicoId] FOREIGN KEY ([CicloAcademicoId]) REFERENCES [CiclosAcademicos] ([CicloAcademicoId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [Boletines] (
        [BoletinId] int NOT NULL IDENTITY,
        [PromedioTrimestre1] decimal(4,1) NOT NULL,
        [PromedioTrimestre2] decimal(4,1) NOT NULL,
        [PromedioTrimestre3] decimal(4,1) NOT NULL,
        [ObservacionTrimestre1] nvarchar(max) NOT NULL,
        [ObservacionTrimestre2] nvarchar(max) NOT NULL,
        [ObservacionTrimestre3] nvarchar(max) NOT NULL,
        [PersonaId] int NOT NULL,
        [LibroDeNotasId] int NOT NULL,
        [LibroDeAsistenciasId] int NOT NULL,
        [EstadoFinalId] int NOT NULL,
        CONSTRAINT [PK_Boletines] PRIMARY KEY ([BoletinId]),
        CONSTRAINT [FK_Boletines_EstadosFinales_EstadoFinalId] FOREIGN KEY ([EstadoFinalId]) REFERENCES [EstadosFinales] ([EstadoFinalId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [GradosAcademicos] (
        [GradoAcademicoId] int NOT NULL IDENTITY,
        [NumGrado] int NOT NULL,
        [CantDeMaterias] int NOT NULL,
        [TipoDeCicloId] int NOT NULL,
        CONSTRAINT [PK_GradosAcademicos] PRIMARY KEY ([GradoAcademicoId]),
        CONSTRAINT [FK_GradosAcademicos_TiposDeCiclos_TipoDeCicloId] FOREIGN KEY ([TipoDeCicloId]) REFERENCES [TiposDeCiclos] ([TipoDeCicloId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [LibrosDeAsistencias] (
        [LibroDeAsistenciasId] int NOT NULL IDENTITY,
        [BoletinId] int NOT NULL,
        CONSTRAINT [PK_LibrosDeAsistencias] PRIMARY KEY ([LibroDeAsistenciasId]),
        CONSTRAINT [FK_LibrosDeAsistencias_Boletines_BoletinId] FOREIGN KEY ([BoletinId]) REFERENCES [Boletines] ([BoletinId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [LibrosDeNotas] (
        [LibroDeNotasId] int NOT NULL IDENTITY,
        [BoletinId] int NOT NULL,
        CONSTRAINT [PK_LibrosDeNotas] PRIMARY KEY ([LibroDeNotasId]),
        CONSTRAINT [FK_LibrosDeNotas_Boletines_BoletinId] FOREIGN KEY ([BoletinId]) REFERENCES [Boletines] ([BoletinId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [Materias] (
        [MateriaId] int NOT NULL IDENTITY,
        [NombreMateria] nvarchar(max) NOT NULL,
        [CodigoMateria] nvarchar(max) NOT NULL,
        [GradoAcademicoId] int NOT NULL,
        CONSTRAINT [PK_Materias] PRIMARY KEY ([MateriaId]),
        CONSTRAINT [FK_Materias_GradosAcademicos_GradoAcademicoId] FOREIGN KEY ([GradoAcademicoId]) REFERENCES [GradosAcademicos] ([GradoAcademicoId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [Personas] (
        [PersonaId] int NOT NULL IDENTITY,
        [Nombre] nvarchar(max) NOT NULL,
        [Apellido] nvarchar(max) NOT NULL,
        [Dni] nvarchar(max) NOT NULL,
        [FechaDeNacimiento] datetime2 NOT NULL,
        [Domicilio] nvarchar(max) NOT NULL,
        [Localidad] nvarchar(max) NOT NULL,
        [CodigoPostal] int NOT NULL,
        [Provincia] nvarchar(max) NOT NULL,
        [Pais] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [SexoId] int NOT NULL,
        [Discriminator] nvarchar(8) NOT NULL,
        [BoletinId] int NULL,
        [CicloAcademicoId] int NULL,
        [GradoAcademicoId] int NULL,
        CONSTRAINT [PK_Personas] PRIMARY KEY ([PersonaId]),
        CONSTRAINT [FK_Personas_Boletines_BoletinId] FOREIGN KEY ([BoletinId]) REFERENCES [Boletines] ([BoletinId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Personas_CiclosAcademicos_CicloAcademicoId] FOREIGN KEY ([CicloAcademicoId]) REFERENCES [CiclosAcademicos] ([CicloAcademicoId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Personas_GradosAcademicos_GradoAcademicoId] FOREIGN KEY ([GradoAcademicoId]) REFERENCES [GradosAcademicos] ([GradoAcademicoId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Personas_Sexos_SexoId] FOREIGN KEY ([SexoId]) REFERENCES [Sexos] ([SexoId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [Asistencias] (
        [AsistenciaId] int NOT NULL IDENTITY,
        [Fecha] datetime2 NOT NULL,
        [NumTrimestre] int NOT NULL,
        [LibroDeAsistenciasId] int NOT NULL,
        [TipoDeAsistenciaId] int NOT NULL,
        CONSTRAINT [PK_Asistencias] PRIMARY KEY ([AsistenciaId]),
        CONSTRAINT [FK_Asistencias_LibrosDeAsistencias_LibroDeAsistenciasId] FOREIGN KEY ([LibroDeAsistenciasId]) REFERENCES [LibrosDeAsistencias] ([LibroDeAsistenciasId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Asistencias_TiposDeAsistencias_TipoDeAsistenciaId] FOREIGN KEY ([TipoDeAsistenciaId]) REFERENCES [TiposDeAsistencias] ([TipoDeAsistenciaId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE TABLE [Examenes] (
        [ExamenId] int NOT NULL IDENTITY,
        [NumTrimestre] int NOT NULL,
        [Nota] decimal(4,1) NOT NULL,
        [LibroDeNotasId] int NOT NULL,
        [MateriaId] int NOT NULL,
        [TipoDeExamenId] int NOT NULL,
        CONSTRAINT [PK_Examenes] PRIMARY KEY ([ExamenId]),
        CONSTRAINT [FK_Examenes_LibrosDeNotas_LibroDeNotasId] FOREIGN KEY ([LibroDeNotasId]) REFERENCES [LibrosDeNotas] ([LibroDeNotasId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Examenes_Materias_MateriaId] FOREIGN KEY ([MateriaId]) REFERENCES [Materias] ([MateriaId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Examenes_TiposDeExamenes_TipoDeExamenId] FOREIGN KEY ([TipoDeExamenId]) REFERENCES [TiposDeExamenes] ([TipoDeExamenId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EstadoFinalId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[EstadosFinales]'))
        SET IDENTITY_INSERT [EstadosFinales] ON;
    EXEC(N'INSERT INTO [EstadosFinales] ([EstadoFinalId], [Codigo], [Nombre])
    VALUES (1, N''A01'', N''Aprobado''),
    (2, N''A02'', N''Reprobado''),
    (3, N''A03'', N''Mes de recuperación'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EstadoFinalId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[EstadosFinales]'))
        SET IDENTITY_INSERT [EstadosFinales] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TipoDeAsistenciaId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[TiposDeAsistencias]'))
        SET IDENTITY_INSERT [TiposDeAsistencias] ON;
    EXEC(N'INSERT INTO [TiposDeAsistencias] ([TipoDeAsistenciaId], [Codigo], [Nombre])
    VALUES (1, N''A01'', N''Presente''),
    (2, N''A02'', N''Ausente''),
    (3, N''A03'', N''Falta justificada''),
    (4, N''A04'', N''Retiro'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TipoDeAsistenciaId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[TiposDeAsistencias]'))
        SET IDENTITY_INSERT [TiposDeAsistencias] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TipoDeCicloId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[TiposDeCiclos]'))
        SET IDENTITY_INSERT [TiposDeCiclos] ON;
    EXEC(N'INSERT INTO [TiposDeCiclos] ([TipoDeCicloId], [Codigo], [Nombre])
    VALUES (1, N''A01'', N''Ciclo Basico''),
    (2, N''A02'', N''Ciclo Superior'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TipoDeCicloId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[TiposDeCiclos]'))
        SET IDENTITY_INSERT [TiposDeCiclos] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TipoDeExamenId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[TiposDeExamenes]'))
        SET IDENTITY_INSERT [TiposDeExamenes] ON;
    EXEC(N'INSERT INTO [TiposDeExamenes] ([TipoDeExamenId], [Codigo], [Nombre])
    VALUES (1, N''A01'', N''Parcial''),
    (2, N''A02'', N''Recuperatorio'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TipoDeExamenId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[TiposDeExamenes]'))
        SET IDENTITY_INSERT [TiposDeExamenes] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'GradoAcademicoId', N'CantDeMaterias', N'NumGrado', N'TipoDeCicloId') AND [object_id] = OBJECT_ID(N'[GradosAcademicos]'))
        SET IDENTITY_INSERT [GradosAcademicos] ON;
    EXEC(N'INSERT INTO [GradosAcademicos] ([GradoAcademicoId], [CantDeMaterias], [NumGrado], [TipoDeCicloId])
    VALUES (1, 8, 1, 1),
    (2, 10, 2, 1),
    (3, 10, 3, 1),
    (4, 11, 4, 2),
    (5, 11, 5, 2),
    (6, 10, 6, 2)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'GradoAcademicoId', N'CantDeMaterias', N'NumGrado', N'TipoDeCicloId') AND [object_id] = OBJECT_ID(N'[GradosAcademicos]'))
        SET IDENTITY_INSERT [GradosAcademicos] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MateriaId', N'CodigoMateria', N'GradoAcademicoId', N'NombreMateria') AND [object_id] = OBJECT_ID(N'[Materias]'))
        SET IDENTITY_INSERT [Materias] ON;
    EXEC(N'INSERT INTO [Materias] ([MateriaId], [CodigoMateria], [GradoAcademicoId], [NombreMateria])
    VALUES (1, N''A01'', 1, N''Ciencias Naturales''),
    (2, N''A02'', 1, N''Ciencias Sociales''),
    (3, N''A03'', 1, N''Educación Artística''),
    (4, N''A04'', 1, N''Educación Física''),
    (5, N''A05'', 1, N''Inglés''),
    (6, N''A06'', 1, N''Matemática''),
    (7, N''A07'', 1, N''Prácticas del Lenguaje''),
    (8, N''A08'', 1, N''Construcción de Ciudadanía''),
    (9, N''B01'', 2, N''Biología''),
    (10, N''B02'', 2, N''Construcción de Ciudadanía''),
    (11, N''B03'', 2, N''Educación Artística''),
    (12, N''B04'', 2, N''Educación Física''),
    (13, N''B05'', 2, N''Físico Química''),
    (14, N''B06'', 2, N''Geografía''),
    (15, N''B07'', 2, N''Historia''),
    (16, N''B08'', 2, N''Inglés''),
    (17, N''B09'', 2, N''Matemática''),
    (18, N''B10'', 2, N''Prácticas del Lenguaje''),
    (19, N''C01'', 3, N''Biología''),
    (20, N''C02'', 3, N''Construcción de Ciudadanía''),
    (21, N''C03'', 3, N''Educación Artística''),
    (22, N''C04'', 3, N''Educación Física''),
    (23, N''C05'', 3, N''Físico Química''),
    (24, N''C06'', 3, N''Geografía''),
    (25, N''C07'', 3, N''Historia''),
    (26, N''C08'', 3, N''Inglés''),
    (27, N''C09'', 3, N''Matemática''),
    (28, N''C10'', 3, N''Prácticas del Lenguaje''),
    (29, N''D01'', 4, N''Matemática''),
    (30, N''D02'', 4, N''Literatura''),
    (31, N''D03'', 4, N''Educación Física''),
    (32, N''D04'', 4, N''Inglés''),
    (33, N''D05'', 4, N''Salud y Adolescencia''),
    (34, N''D06'', 4, N''Biología''),
    (35, N''D07'', 4, N''Historia''),
    (36, N''D08'', 4, N''Geografía''),
    (37, N''D09'', 4, N''NTICx''),
    (38, N''D10'', 4, N''Psicología''),
    (39, N''E01'', 5, N''Matemática''),
    (40, N''E02'', 5, N''Literatura''),
    (41, N''E03'', 5, N''Educación Física''),
    (42, N''E04'', 5, N''Inglés'');
    INSERT INTO [Materias] ([MateriaId], [CodigoMateria], [GradoAcademicoId], [NombreMateria])
    VALUES (43, N''E05'', 5, N''Política y Ciudadanía''),
    (44, N''E06'', 5, N''Introducción a la Química''),
    (45, N''E07'', 5, N''Comunicación, Cultura y Sociedad''),
    (46, N''E08'', 5, N''Historia''),
    (47, N''E09'', 5, N''Geografía''),
    (48, N''E10'', 5, N''Economía Política''),
    (49, N''E11'', 5, N''Sociología''),
    (50, N''F01'', 6, N''Matemática''),
    (51, N''F02'', 6, N''Literatura''),
    (52, N''F03'', 6, N''Educación Física''),
    (53, N''F04'', 6, N''Inglés''),
    (54, N''F05'', 6, N''Trabajo y Ciudadanía''),
    (55, N''F06'', 6, N''Proyecto de Investigación en Ciencias Sociales''),
    (56, N''F07'', 6, N''Historia''),
    (57, N''F08'', 6, N''Geografía''),
    (58, N''F09'', 6, N''Arte''),
    (59, N''F10'', 6, N''Filosofía'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MateriaId', N'CodigoMateria', N'GradoAcademicoId', N'NombreMateria') AND [object_id] = OBJECT_ID(N'[Materias]'))
        SET IDENTITY_INSERT [Materias] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Asistencias_LibroDeAsistenciasId] ON [Asistencias] ([LibroDeAsistenciasId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Asistencias_TipoDeAsistenciaId] ON [Asistencias] ([TipoDeAsistenciaId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Boletines_EstadoFinalId] ON [Boletines] ([EstadoFinalId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Examenes_LibroDeNotasId] ON [Examenes] ([LibroDeNotasId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Examenes_MateriaId] ON [Examenes] ([MateriaId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Examenes_TipoDeExamenId] ON [Examenes] ([TipoDeExamenId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_GradosAcademicos_TipoDeCicloId] ON [GradosAcademicos] ([TipoDeCicloId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE UNIQUE INDEX [IX_LibrosDeAsistencias_BoletinId] ON [LibrosDeAsistencias] ([BoletinId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE UNIQUE INDEX [IX_LibrosDeNotas_BoletinId] ON [LibrosDeNotas] ([BoletinId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Materias_GradoAcademicoId] ON [Materias] ([GradoAcademicoId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_Personas_BoletinId] ON [Personas] ([BoletinId]) WHERE [BoletinId] IS NOT NULL');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Personas_CicloAcademicoId] ON [Personas] ([CicloAcademicoId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Personas_GradoAcademicoId] ON [Personas] ([GradoAcademicoId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Personas_SexoId] ON [Personas] ([SexoId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    CREATE INDEX [IX_Trimestres_CicloAcademicoId] ON [Trimestres] ([CicloAcademicoId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240821170242_Migracion1'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240821170242_Migracion1', N'8.0.8');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240828174958_Migracion2'
)
BEGIN
    ALTER TABLE [Personas] DROP CONSTRAINT [FK_Personas_Boletines_BoletinId];
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240828174958_Migracion2'
)
BEGIN
    DROP INDEX [IX_Personas_BoletinId] ON [Personas];
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240828174958_Migracion2'
)
BEGIN
    CREATE INDEX [IX_Boletines_PersonaId] ON [Boletines] ([PersonaId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240828174958_Migracion2'
)
BEGIN
    ALTER TABLE [Boletines] ADD CONSTRAINT [FK_Boletines_Personas_PersonaId] FOREIGN KEY ([PersonaId]) REFERENCES [Personas] ([PersonaId]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240828174958_Migracion2'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240828174958_Migracion2', N'8.0.8');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240828182250_Migracion3'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SexoId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[Sexos]'))
        SET IDENTITY_INSERT [Sexos] ON;
    EXEC(N'INSERT INTO [Sexos] ([SexoId], [Codigo], [Nombre])
    VALUES (1, N''A1'', N''Masculino''),
    (2, N''A2'', N''Femenino'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SexoId', N'Codigo', N'Nombre') AND [object_id] = OBJECT_ID(N'[Sexos]'))
        SET IDENTITY_INSERT [Sexos] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240828182250_Migracion3'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240828182250_Migracion3', N'8.0.8');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240901171301_Migracion4'
)
BEGIN
    ALTER TABLE [Boletines] ADD [Año] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240901171301_Migracion4'
)
BEGIN
    ALTER TABLE [Boletines] ADD [numGrado] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240901171301_Migracion4'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240901171301_Migracion4', N'8.0.8');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240901182031_Migracion5'
)
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Personas]') AND [c].[name] = N'BoletinId');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Personas] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Personas] DROP COLUMN [BoletinId];
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240901182031_Migracion5'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240901182031_Migracion5', N'8.0.8');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240901185411_Migracion6'
)
BEGIN
    ALTER TABLE [Boletines] ADD [Activo] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240901185411_Migracion6'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240901185411_Migracion6', N'8.0.8');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240909133247_Migracion7'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240909133247_Migracion7', N'8.0.8');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240910184546_Migracion8'
)
BEGIN
    ALTER TABLE [Boletines] ADD [PromedioAsistenciaTrimestre1] decimal(4,1) NOT NULL DEFAULT 0.0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240910184546_Migracion8'
)
BEGIN
    ALTER TABLE [Boletines] ADD [PromedioAsistenciaTrimestre2] decimal(4,1) NOT NULL DEFAULT 0.0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240910184546_Migracion8'
)
BEGIN
    ALTER TABLE [Boletines] ADD [PromedioAsistenciaTrimestre3] decimal(4,1) NOT NULL DEFAULT 0.0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240910184546_Migracion8'
)
BEGIN
    ALTER TABLE [Boletines] ADD [PromedioTotalAsistencia] decimal(4,1) NOT NULL DEFAULT 0.0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240910184546_Migracion8'
)
BEGIN
    ALTER TABLE [Boletines] ADD [PromedioTotalExamenes] decimal(4,1) NOT NULL DEFAULT 0.0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240910184546_Migracion8'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240910184546_Migracion8', N'8.0.8');
END;
GO

COMMIT;
GO

