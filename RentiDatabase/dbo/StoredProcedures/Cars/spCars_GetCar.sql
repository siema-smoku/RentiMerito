CREATE PROCEDURE [dbo].[spCars_GetCar]
	@CarId int
AS
BEGIN
	SELECT CarId, CarBrand, CarName, CarImage, IsRented, RentStartDate, RentEndDate, RentUserId
	FROM dbo.[Cars]
	WHERE CarId = @CarId;
END
