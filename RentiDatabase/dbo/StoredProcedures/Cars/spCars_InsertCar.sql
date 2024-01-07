CREATE PROCEDURE [dbo].[spCars_InsertCar]
	@CarBrand nvarchar(50),
	@CarName nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.[Cars] (CarBrand, CarName, IsRented)
	VALUES (@CarBrand, @CarName, 0);
END
