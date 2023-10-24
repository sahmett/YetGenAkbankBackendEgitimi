 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextsController : ControllerBase
    {
        [HttpGet("[action]")]
        public string TrimText(string text)
        {
            return text.Trim();
        }

        [HttpGet("[action]/{text}")]
        public string UpperText(string text)
        {
            return text.ToUpper();
        }

        [HttpPost("[action]")]
        public string LowerText([FromBody]string text)
        {
            return text.ToLower();
        }
    }
}
