using CarBook.Dto.LocationDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7152/api/Locations");
            
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
                List<SelectListItem> values2=(from x in values
                                              select new SelectListItem
                                              {
                                                  Text=x.Name,
                                                  Value=x.LocationId.ToString()
                                              }).ToList();
                ViewBag.v=values2;
                return View();
            

        }
        [HttpPost]
        public IActionResult Index(string book_pick_date, string book_off_date, string time_pick,string time_off, string locationId)
        {
            TempData["bookpickdate"]= book_pick_date;
            TempData["bookoffdate"]= book_off_date;
            TempData["timepick"] = time_pick;
            TempData["timeoff"] = time_off;
            TempData["locationId"] = locationId;
            return RedirectToAction("Index","RentACarList");
        }
    }
}
