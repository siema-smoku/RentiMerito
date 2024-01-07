using Domain.Data;
using Domain.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CarService : ICarService
    {
        private readonly ICarData _carData;

        public CarService(ICarData carData)
        {
            _carData = carData;
        }

        public List<CarModel> DisplaySixCars()
        {
            var cars = _carData.GetNonRentedCars().Result.Take(6).ToList();
            return cars;
        }

        public CarModel? GetCarById(int id) 
        {
            return _carData.GetCarById(id).Result;
        }
    }
}
