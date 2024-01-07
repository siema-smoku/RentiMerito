using Microsoft.AspNetCore.Mvc;

namespace RentiMerito.Controllers
{
    public class RentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
