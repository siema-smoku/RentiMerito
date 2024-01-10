using Domain.Models.Cars;

namespace Domain.Services.Cars
{
    public interface ICarService
    {
        List<CarModel> DisplaySixCars();
        CarModel? GetCarById(int id);
        List<CarModel> GetNonRentedCars();
        List<CarModel> GetRentableCars(string city, DateTime startDate, DateTime endDate);
    }
}