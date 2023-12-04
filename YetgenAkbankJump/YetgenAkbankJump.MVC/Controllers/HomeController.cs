using Microsoft.AspNetCore.Mvc;
using Resend;
using System.Diagnostics;
using YetgenAkbankJump.MVC.Models;

namespace YetgenAkbankJump.MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IResend _resend;
		public HomeController(ILogger<HomeController> logger, IResend resend)
		{
			_logger = logger;
			_resend = resend;
		}

		public async Task<IActionResult> IndexAsync()
		{
			var message = new EmailMessage();

			message.From = "onboarding@resend.dev";
			message.To.Add("myapp@example.com");
			message.Subject = "Hello!";
			message.HtmlBody = "<div><strong>Greetings<strong> 👋🏻 from .NET</div>";

			await _resend.EmailSendAsync(message);

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}