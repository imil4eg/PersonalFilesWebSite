CREATE TABLE [dbo].[ScientificWork]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PersonId] INT NOT NULL, 
    [WorkType] NVARCHAR(MAX) NOT NULL, 
    [WorkName] NVARCHAR(MAX) NOT NULL, 
    [File] VARBINARY(MAX) NOT NULL, 
    [Site] NVARCHAR(MAX) NOT NULL, 
    [Year] DATE NOT NULL, 
    CONSTRAINT [FK_ScientificWork_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
