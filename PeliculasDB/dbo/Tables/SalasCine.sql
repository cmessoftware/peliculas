CREATE TABLE [dbo].[SalasCine] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]     NVARCHAR (MAX) NOT NULL,
    [Tipo]       INT            NOT NULL,
    [Precio]     DECIMAL (5, 2) NOT NULL,
    [CineId]     INT            NOT NULL,
    [PeliculaId] INT            NULL,
    CONSTRAINT [PK_SalasCine] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SalasCine_Cines_CineId] FOREIGN KEY ([CineId]) REFERENCES [dbo].[Cines] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SalasCine_Peliculas_PeliculaId] FOREIGN KEY ([PeliculaId]) REFERENCES [dbo].[Peliculas] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_SalasCine_CineId]
    ON [dbo].[SalasCine]([CineId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_SalasCine_PeliculaId]
    ON [dbo].[SalasCine]([PeliculaId] ASC);

