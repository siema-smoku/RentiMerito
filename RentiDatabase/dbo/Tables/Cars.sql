CREATE TABLE [dbo].[Cars]
(
	[CarId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CarBrand] NVARCHAR(50) NOT NULL, 
    [CarName] NVARCHAR(50) NOT NULL, 
    [CarImage] NVARCHAR(500) NULL,
    [IsRented] BIT NOT NULL, 
    [RentStartDate] DATE NULL, 
    [RentEndDate] DATE NULL, 
    [RentUserId] INT NULL
)
