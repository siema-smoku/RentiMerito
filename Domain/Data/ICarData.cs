using Domain.Models.Cars;

namespace Domain.Data
{
    public interface ICarData
    {
        Task DeleteCar(int id);
        Task<CarModel?> GetCarById(int id);
        Task<IEnumerable<CarModel>> GetCars();
        Task InsertCar(CarModel car);
        Task UpdateCar(CarModel car);
        Task<IEnumerable<CarModel>> GetNonRentedCars();
    }
}