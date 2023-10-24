using CarMatik.WebApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarMatik.WebApi.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarsController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetAll()
		{
			var cars = CarsContext.LuxuryCars.ToList();

			return Ok(cars); //işlem başarılıysa return ok de yolla -return not found  

		}
		[HttpGet("{id:guid}")]
		public IActionResult GetById(Guid id) 
		{
			//var car = CarsContext.LuxuryCars.FirstOrDefault(x => x.Id == id);

			//return Ok(car);

			if (id == Guid.Empty)
			{
				return BadRequest("Id cannot be empty.");
			}
            var car = CarsContext.LuxuryCars.FirstOrDefault(x => x.Id == id);

			if (car == null)
			{
				return NotFound("The car requested with given Id was not found.");
			}

			return Ok(car);
        }
	}
}
