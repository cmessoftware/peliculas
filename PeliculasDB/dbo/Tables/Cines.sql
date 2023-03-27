CREATE TABLE [dbo].[Cines] (
    [Id]        INT               IDENTITY (1, 1) NOT NULL,
    [Nombre]    NVARCHAR (MAX)    NOT NULL,
    [Cadena]    NVARCHAR (MAX)    NOT NULL,
    [Ubicacion] [sys].[geography] NOT NULL,
    CONSTRAINT [PK_Cines] PRIMARY KEY CLUSTERED ([Id] ASC)
);

