using DependencyInjection.Application.Services;
using DependencyInjection.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly IConfigurationService _configurationService;

		public CustomerController(IConfigurationService configurationService)
		{
			_configurationService = configurationService;
		}

		// GET: api/Customer?key=myKey
		[HttpGet]
		public IActionResult Get(string key)
		{
			var value = _configurationService.GetValue(key);
			return Ok(value);
		}
	}
}
