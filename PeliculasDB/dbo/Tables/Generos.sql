CREATE TABLE [dbo].[Generos] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]     NVARCHAR (100) NOT NULL,
    [PeliculaId] INT            NULL,
    CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Generos_Peliculas_PeliculaId] FOREIGN KEY ([PeliculaId]) REFERENCES [dbo].[Peliculas] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Generos_PeliculaId]
    ON [dbo].[Generos]([PeliculaId] ASC);

