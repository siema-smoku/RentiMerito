using Domain.Models.Cars;
using Domain.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class CarData : ICarData
    {
        private readonly ISqlDataAccess _db;

        public CarData(ISqlDataAccess sqlDataAccess)
        {
            _db = sqlDataAccess;
        }

        public async Task<IEnumerable<CarModel>> GetCars()
        {
            return await _db.LoadData<CarModel, dynamic>("dbo.spCars_GetAll", new { });
        }

        public async Task<CarModel?> GetCarById(int id)
        {
            var result = await _db.LoadData<CarModel, dynamic>("dbo.spCars_GetCar", new { CarId = id });
            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<CarModel>> GetNonRentedCars()
        {
            return await _db.LoadData<CarModel, dynamic>("dbo.spCars_GetNonRented", new { });
        }

        public Task InsertCar(CarModel car)
        {
            return _db.SaveData("dbo.spCar_InserCar", new { car.CarName, car.CarBrand });
        }

        public Task UpdateCar(CarModel car)
        {
            return _db.SaveData("dbo.spCar_UpdateCar", car);
        }

        public Task DeleteCar(int id)
        {
            return _db.SaveData("dbo.spCar_DeleteCar", new { CarId = id });
        }
    }
}
