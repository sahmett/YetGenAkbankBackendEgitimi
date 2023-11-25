 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar.Domain.Utilties;

namespace RentCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextsController : ControllerBase
    {
		private readonly RequestCountService _requestCountService;

		public TextsController()
		{
			_requestCountService = new();
		}

		[HttpGet("[action]")]
        public string TrimText(string text)
        {
			_requestCountService.Count += 1;
			return text.Trim();
        }

        [HttpGet("[action]/{text}")]
        public string UpperText(string text)
        {
			_requestCountService.Count += 1;

            return text.ToUpper();
        }

        [HttpPost("[action]")]
        public string LowerText([FromBody]string text)
        {
            _requestCountService.Count += 1;
            return text.ToLower();
        }

		[HttpGet("GetRequestCount")]
		public IActionResult GetRequestCount()
		{
			_requestCountService.Count += 1;

			return Ok(_requestCountService.Count);
		}
	}
}
