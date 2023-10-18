using Microsoft.AspNetCore.Mvc;
using ReDoReMusic.Domain.Entities;
using ReDoReMusic.Persistence.Context;

namespace ReDoReMusic.MVC.Controllers
{
	public class BrandController : Controller
	{
		private readonly ReDoReMusicDbContext _context;

		public BrandController() 
		{ 
			_context = new ReDoReMusicDbContext(); //ilerde degisecek

		}
		public IActionResult Index()
		{	
			var brands = _context.Brands.ToList();
			return View(brands);
		}

		[HttpGet]
		public IActionResult AddBrand()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddBrand(string brandName, string brandDisplayText, string brandAddress)
		{
			var brand = new Brand()
			{
				Id = Guid.NewGuid(),
				Name = brandName,
				DisplayText = brandDisplayText,
				Address = brandAddress,
				CreatedOn = DateTime.UtcNow,
			};
			_context.Brands.Add(brand);
			_context.SaveChanges();

			return View();
		}

		[HttpGet]
		public IActionResult DeleteBrand(string id)
		{
			var brand = _context.Brands.Where(x => x.Id==Guid.Parse(id)).FirstOrDefault();
			_context.Brands.Remove(brand);
			_context.SaveChanges();

			return RedirectToAction("index");
		}

	}
}
