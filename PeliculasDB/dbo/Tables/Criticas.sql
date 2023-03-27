CREATE TABLE [dbo].[Criticas] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Contenido]  NVARCHAR (MAX) NOT NULL,
    [Autor]      NVARCHAR (MAX) NOT NULL,
    [PeliculaId] INT            NULL,
    CONSTRAINT [PK_Criticas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Criticas_Peliculas_PeliculaId] FOREIGN KEY ([PeliculaId]) REFERENCES [dbo].[Peliculas] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Criticas_PeliculaId]
    ON [dbo].[Criticas]([PeliculaId] ASC);

