using Microsoft.AspNetCore.Mvc;
using ReDoReMusic.Persistence;

namespace ReDoReMusic.MVC.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			Configuration.GetString("ConnectionString:PostgreSQL");

			return View();
		}
	}
}
