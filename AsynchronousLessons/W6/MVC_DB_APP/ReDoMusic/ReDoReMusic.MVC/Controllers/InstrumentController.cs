using Microsoft.AspNetCore.Mvc;
using ReDoReMusic.Domain.Entities;
using ReDoReMusic.Domain.Enum;
using ReDoReMusic.Persistence.Context;

namespace ReDoReMusic.MVC.Controllers
{
	public class InstrumentController : Controller
	{
		private readonly ReDoReMusicDbContext _context;

		public InstrumentController()
		{
			_context = new ReDoReMusicDbContext();
		}
		public IActionResult Index()
		{
			var instruments = _context.InstrumentsDb.ToList(); //önemli model alır
			return View(instruments);
		}

		[HttpGet]
		public IActionResult AddInstrument() 
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddInstrument(string instrumentName, string instrumentBrand,string instrumentModel,
			Color instrumentColor, string instrumentProductionYear, decimal instrumentPrice) 
		{
			var instrument = new Instrument()
			{
				Id = Guid.NewGuid(),
				Name = instrumentName,
				Brand = instrumentBrand,
				Model = instrumentModel,
				Color = instrumentColor,
				ProductionYear = instrumentProductionYear,
				Price = instrumentPrice,
			};

			_context.InstrumentsDb.Add(instrument);
			_context.SaveChanges();

			return View();
		}

		public IActionResult DeleteInstrument(string id)
		{
			var instrument = _context.InstrumentsDb.Where(x=> x.Id==Guid.Parse(id)).FirstOrDefault();
			_context.InstrumentsDb.Remove(instrument);
			_context.SaveChanges();

			return RedirectToAction("index");
		}



	}
}
