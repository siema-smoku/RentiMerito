using Domain.Models.Cars;

namespace Domain.Services
{
    public interface ICarService
    {
        List<CarModel> DisplaySixCars();
        CarModel? GetCarById(int id);
    }
}