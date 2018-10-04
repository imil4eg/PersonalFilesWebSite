CREATE TABLE [dbo].[MilitaryId]
(
	[PersonId] INT NOT NULL PRIMARY KEY, 
    [NumberOfUnit] INT NOT NULL, 
    [Place] NVARCHAR(MAX) NOT NULL, 
    [BegginingDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL, 
    [Rank] NVARCHAR(MAX) NOT NULL, 
    [GaveBy] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_MilitaryId_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
