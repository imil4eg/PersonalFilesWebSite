CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PersonId] INT NOT NULL, 
    [DocumentType] NVARCHAR(MAX) NOT NULL, 
    [File] VARBINARY(MAX) NOT NULL, 
    [Year] DATE NOT NULL, 
    CONSTRAINT [FK_OtherDocument_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
