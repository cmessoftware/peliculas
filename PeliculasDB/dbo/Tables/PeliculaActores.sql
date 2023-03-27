CREATE TABLE [dbo].[PeliculaActores] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [PeliculaId]  INT            NOT NULL,
    [ActorId]     INT            NOT NULL,
    [Personaje]   NVARCHAR (MAX) NOT NULL,
    [EsPrincipal] BIT            NOT NULL,
    [Orden]       INT            NOT NULL,
    CONSTRAINT [PK_PeliculaActores] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PeliculaActores_Actores_ActorId] FOREIGN KEY ([ActorId]) REFERENCES [dbo].[Actores] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PeliculaActores_Peliculas_PeliculaId] FOREIGN KEY ([PeliculaId]) REFERENCES [dbo].[Peliculas] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_PeliculaActores_ActorId]
    ON [dbo].[PeliculaActores]([ActorId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_PeliculaActores_PeliculaId]
    ON [dbo].[PeliculaActores]([PeliculaId] ASC);

