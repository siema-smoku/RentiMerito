﻿using Domain.Data;
using Domain.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Cars
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

        public List<CarModel> GetNonRentedCars()
        {
            return _carData.GetNonRentedCars().Result.ToList();
        }
        public CarModel? GetCarById(int id)
        {
            return _carData.GetCarById(id).Result;
        }

        public List<CarModel> GetRentableCars(string city, DateTime startDate, DateTime endDate)
        {
            var result = new List<CarModel>();
            var allCars = _carData.GetCars().Result;
            foreach (var car in allCars)
            {
                if(car.CarCity == city )
                {
                    if (!car.IsRented)
                    {
                        result.Add(car);
                    }
                    else if (car.RentEndDate < startDate)
                    {
                        result.Add(car);
                    }
                }
            }
            return result;
        }
    }
}
