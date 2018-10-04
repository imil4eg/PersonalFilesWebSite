CREATE TABLE [dbo].[ApplicationUser]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [UserName] NVARCHAR(256) NOT NULL,
    [Email] NVARCHAR(256) NULL,
    [PasswordHash] NVARCHAR(MAX) NULL,
    [TwoFactorEnabled] BIT NOT NULL
)
