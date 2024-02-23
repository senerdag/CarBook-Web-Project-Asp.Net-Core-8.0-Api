using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class UILayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
