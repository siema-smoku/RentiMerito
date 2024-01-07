using Domain.Services.Cars;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace RentiMerito.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            var cars = _carService.GetNonRentedCars();
            return View(cars);
        }

        public IActionResult CarDetails(int carId)
        {
            var car = _carService.GetCarById(carId);
            return View(car);
        }
    }
}
