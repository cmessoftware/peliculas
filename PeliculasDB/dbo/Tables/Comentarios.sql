CREATE TABLE [dbo].[Comentarios] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Contenido]       NVARCHAR (MAX) NOT NULL,
    [Usuario]         NVARCHAR (MAX) NOT NULL,
    [MeGustaCantidad] INT            NOT NULL,
    [PeliculaId]      INT            NULL,
    CONSTRAINT [PK_Comentarios] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comentarios_Peliculas_PeliculaId] FOREIGN KEY ([PeliculaId]) REFERENCES [dbo].[Peliculas] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Comentarios_PeliculaId]
    ON [dbo].[Comentarios]([PeliculaId] ASC);

