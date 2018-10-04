CREATE TABLE [dbo].[WorkContact]
(
	[PersonId] INT NOT NULL PRIMARY KEY, 
    [File] VARBINARY(MAX) NOT NULL, 
    [Date] DATE NOT NULL, 
    CONSTRAINT [FK_WorkContact_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
