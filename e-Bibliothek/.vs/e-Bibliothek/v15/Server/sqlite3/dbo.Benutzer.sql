CREATE TABLE [dbo].[Benutzer] (
    [Id]           INT NOT NULL IDENTITY,
    [BenutzerName] VARCHAR (30)     NOT NULL,
    [PassWd]       VARCHAR (30)     NOT NULL,
    [BDate]        DATE             NOT NULL,
    [Adresse]      VARCHAR (30)     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [PK_Benutzer] PRIMARY KEY ([Id]), 
    CONSTRAINT [PK_Benutzer] PRIMARY KEY ([Id])
);