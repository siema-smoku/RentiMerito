CREATE PROCEDURE [dbo].[spCars_GetAll]
AS
BEGIN
	SELECT CarId, CarBrand, CarName, CarImage, IsRented, RentStartDate, RentEndDate, RentUserId
	FROM dbo.[Cars];
END
