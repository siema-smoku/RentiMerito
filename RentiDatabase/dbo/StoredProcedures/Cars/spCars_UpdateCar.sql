CREATE PROCEDURE [dbo].[spCars_UpdateCar]
	@CarId int,
	@CarBrand nvarchar(50),
	@CarName nvarchar(50)
AS
BEGIN
	UPDATE dbo.[Cars]
	SET CarBrand = @CarBrand, CarName = @CarName
	WHERE CarId = @CarId;
END
