CREATE TABLE [dbo].[Actores] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [Nombre]     NVARCHAR (50)   NOT NULL,
    [Edad]       INT             NOT NULL,
    [FotoURL]    NVARCHAR (MAX)  NOT NULL,
    [PaisOrigen] INT             NOT NULL,
    [Biografia]  NVARCHAR (2000) NOT NULL,
    CONSTRAINT [PK_Actores] PRIMARY KEY CLUSTERED ([Id] ASC)
);

