CREATE TABLE [dbo].[Passport]
(
	[PersonId] INT NOT NULL PRIMARY KEY, 
    [Number] NVARCHAR(15) NOT NULL, 
    [Series] NVARCHAR(15) NOT NULL, 
    [GivenBy] NVARCHAR(MAX) NOT NULL, 
    [DateOfGive] DATE NOT NULL, 
    [Address] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_Passport_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
