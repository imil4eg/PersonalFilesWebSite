CREATE TABLE [dbo].[Education]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PersonId] INT NOT NULL, 
    [File] VARBINARY(MAX) NOT NULL, 
    [EndDate] DATE NOT NULL, 
    CONSTRAINT [FK_Education_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
