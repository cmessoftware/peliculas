CREATE TABLE [dbo].[CineOfertas] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [FechaInicio]         DATE           NOT NULL,
    [FechaFin]            DATE           NOT NULL,
    [PorcentajeDescuento] DECIMAL (2, 2) NOT NULL,
    [CineId]              INT            NOT NULL,
    CONSTRAINT [PK_CineOfertas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

