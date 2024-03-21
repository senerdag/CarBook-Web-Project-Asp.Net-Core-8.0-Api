using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Rent A Car";
            ViewBag.v2 = "Car Reservation Form";
            return View();
        }
    }
}
