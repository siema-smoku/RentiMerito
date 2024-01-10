using Domain.Services.Cars;
using Microsoft.AspNetCore.Mvc;

namespace RentiMerito.Controllers
{
    public class RentController : Controller
    {
        private readonly ICarService _carService;

        public RentController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RentCar()
        {
            return View();
        }

        public IActionResult RentableCars(string city, DateTime startDate, DateTime endDate)
        {
            var rentableCars = _carService.GetRentableCars(city, startDate, endDate);
            return View(rentableCars);
        }
    }
}
