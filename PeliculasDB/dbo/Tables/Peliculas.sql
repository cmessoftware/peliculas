CREATE TABLE [dbo].[Peliculas] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Titulo]       NVARCHAR (250) NOT NULL,
    [FechaEstreno] DATE           NOT NULL,
    [PaisOrigen]   INT            NOT NULL,
    [Resumen]      NVARCHAR (MAX) NOT NULL,
    [Director]     NVARCHAR (MAX) NOT NULL,
    [PosterLink]   VARCHAR (500)  NOT NULL,
    [TrailerLink]  VARCHAR (500)  NOT NULL,
    [CineId]       INT            NULL,
    CONSTRAINT [PK_Peliculas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Peliculas_Cines_CineId] FOREIGN KEY ([CineId]) REFERENCES [dbo].[Cines] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Peliculas_CineId]
    ON [dbo].[Peliculas]([CineId] ASC);

