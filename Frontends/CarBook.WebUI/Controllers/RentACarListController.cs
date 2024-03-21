using CarBook.Dto.BrandDtos;
using CarBook.Dto.RentACarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index(int id)
        {
           
            var locationId = TempData["locationId"];

            //filterRentACarDto.LocationId = int.Parse(locationId.ToString());
            //filterRentACarDto.Available = true;
            id = int.Parse(locationId.ToString());

            //ViewBag.bookpickdate = bookpickdate;
            //ViewBag.bookoffdate = bookoffdate;
            //ViewBag.timepick = timepick;
            //ViewBag.timeoff = timeoff;
            ViewBag.locationId = locationId;


            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7152/api/RentACars?locationId={id}&available=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
