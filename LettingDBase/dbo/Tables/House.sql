CREATE TABLE [dbo].[House]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Address] NVARCHAR(50) NOT NULL, 
    [Type] NVARCHAR(50) NOT NULL, 
    [Price] DECIMAL NOT NULL, 
    [IsAvailable] NVARCHAR(50) NOT NULL
)
