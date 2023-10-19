using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
			var instruments = _context.InstrumentsDb.Include(x=>x.Brand).ToList(); //önemli model alır
			return View(instruments);
		}

		
		public IActionResult AddInstrument()  //brandları yolluyoruz ki oradan form çeksin
		{
			var brands = _context.Brands.ToList();
			return View(brands);
		}

		[HttpPost]
		public IActionResult AddInstrument(string instrumentName, string instrumentBrandId,string instrumentModel,
			Color instrumentColor, string instrumentProductionYear, decimal instrumentPrice) 
		{
			//firs or def gerekli mi?
			var brand = _context.Brands.Where(x => x.Id == Guid.Parse(instrumentBrandId)).FirstOrDefault(); //firs or def gerekli mi?

			var instrument = new Instrument()
			{
				Id = Guid.NewGuid(),
				Name = instrumentName,
				Brand = brand,
				Model = instrumentModel,
				Color = instrumentColor,
				ProductionYear = instrumentProductionYear,
				Price = instrumentPrice,
				
		};

			_context.InstrumentsDb.Add(instrument);
			_context.SaveChanges();

			return AddInstrument();
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
