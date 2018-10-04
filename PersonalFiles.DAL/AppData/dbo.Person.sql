CREATE TABLE [dbo].[Person] (
    [Id]         INT           NOT NULL,
    [LastName]   NVARCHAR (50) NOT NULL,
    [FirstName]  NVARCHAR (50) NOT NULL,
    [MiddleName] NVARCHAR (50) NULL,
    [Gender]     INT           NOT NULL,
    [SNILS]      NVARCHAR (11) NULL,
    [INN]        NVARCHAR (13) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Person_ToApplicationUser] FOREIGN KEY ([Id]) REFERENCES [ApplicationUser]([Id])
);

