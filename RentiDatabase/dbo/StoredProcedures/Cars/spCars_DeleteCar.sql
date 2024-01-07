CREATE PROCEDURE [dbo].[spCars_DeleteCar]
	@CarId int
AS
BEGIN
	DELETE
	FROM dbo.[Cars]
	WHERE CarId = @CarId;
END
