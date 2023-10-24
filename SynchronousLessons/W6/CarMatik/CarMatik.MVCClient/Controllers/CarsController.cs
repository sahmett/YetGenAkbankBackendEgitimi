using CarMatik.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarMatik.MVCClient.Controllers
{
    public class CarsController : Controller
    {
        private readonly HttpClient _httpClient;

        public CarsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var cars = await _httpClient.GetFromJsonAsync<List<Car>>("Cars");

            return View(cars);
        }

    }
}
