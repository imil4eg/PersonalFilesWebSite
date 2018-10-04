CREATE TABLE [dbo].[Autobiography]
(
	[PersonId] INT NOT NULL PRIMARY KEY, 
    [File] VARBINARY(MAX) NOT NULL, 
    CONSTRAINT [FK_Autobiography_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
