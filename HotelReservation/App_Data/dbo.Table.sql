CREATE TABLE [dbo].[Clients]
(
	[ClientId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FIO] VARCHAR(50) NOT NULL, 
    [PassportID] INT NOT NULL, 
    [BirthdayDate] DATE NOT NULL, 
    [Sex] BIT NOT NULL
)
