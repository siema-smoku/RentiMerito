CREATE PROCEDURE [dbo].[spCars_GetNonRented]
AS
BEGIN
	SELECT CarId, CarBrand, CarName, CarImage, IsRented, RentStartDate, RentEndDate, RentUserId
	FROM dbo.[Cars]
	WHERE IsRented = 0;
END