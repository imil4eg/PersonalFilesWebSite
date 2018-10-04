CREATE TABLE [dbo].[WorkBook]
(
	[PersonId] INT NOT NULL PRIMARY KEY, 
    [Post] NVARCHAR(MAX) NOT NULL, 
    [DateOfBeggining] DATE NOT NULL, 
    CONSTRAINT [FK_WorkBook_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
