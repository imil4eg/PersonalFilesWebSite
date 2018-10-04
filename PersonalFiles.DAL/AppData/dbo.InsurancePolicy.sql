CREATE TABLE [dbo].[InsurancePolicy]
(
	[PersonId] INT NOT NULL PRIMARY KEY, 
    [Number] NVARCHAR(50) NOT NULL, 
    [Company] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_Insurance_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
