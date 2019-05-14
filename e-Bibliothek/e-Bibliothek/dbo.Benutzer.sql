CREATE TABLE [dbo].[Benutzer] (
    [Id]           UNIQUEIDENTIFIER NOT NULL IDENTITY,
    [BenutzerName] VARCHAR (30)     NOT NULL,
    [PassWd]       VARCHAR (30)     NOT NULL,
    [BDate]        DATE             NOT NULL,
    [Adresse]      VARCHAR (30)     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

