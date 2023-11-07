using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReDoReMusic.Domain.Common;
using ReDoReMusic.Domain.Entities;
using ReDoReMusic.Domain.Enum;
using ReDoReMusic.MVC.Models;
using ReDoReMusic.Persistence.Context;
using System.Diagnostics.Metrics;

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
			var instruments = _context.InstrumentsDb.Include(x=>x.Brand).ToList(); //eager loading - Instrument nesnesini döndürürken onunla ilişkili Brand
            return View(instruments);
		}

		[HttpGet]
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

			var instrument = new Domain.Entities.Instrument()
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

		//public IActionResult DeleteInstrument(string id)
		//{
		//	var instrument = _context.InstrumentsDb.Where(x => x.Id == Guid.Parse(id)).FirstOrDefault();
		//	_context.InstrumentsDb.Remove(instrument);
		//	_context.SaveChanges();

		//	return RedirectToAction("index");
		//}

		[Route("[controller]/[action]/{id}")]
		public IActionResult DeleteInstrument(string id)
		{
			var instrument = _context.InstrumentsDb
				.FirstOrDefault(x => x.Id == Guid.Parse(id));

			if (instrument == null)
			{
				return NotFound();
			}

			_context.InstrumentsDb.Remove(instrument);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateInstrument(string id)  //brandları ve inst yolluyoruz ki oradan form çeksin
		{
			var instrument = _context.InstrumentsDb.Where(x => x.Id == Guid.Parse(id)).FirstOrDefault();
			
			if (instrument is null)
			{
				return NotFound();
			}
			var viewModel = new InstrumentViewModel
			{
				Brands = _context.Brands.ToList(),
				Instruments = _context.InstrumentsDb.ToList(),
				Instrument = instrument
			};

			return View(viewModel);
		}

		[HttpPost]
		public IActionResult UpdateInstrument(string id, string instrumentName, string instrumentBrandId,
	string instrumentModel, string instrumentColor, string instrumentProductionYear, decimal instrumentPrice)
		{

			if (id is null)
			{
				return NotFound();
			}

			var instrument = _context.InstrumentsDb.Where(x => x.Id == Guid.Parse(id)).FirstOrDefault();

			if (instrument is null)
			{
				return NotFound();
			}

			instrument.Name = instrumentName;
			instrument.Brand = _context.Brands.FirstOrDefault(x => x.Id == Guid.Parse(instrumentBrandId)); // Marka güncelle
			instrument.Model = instrumentModel;

			if (Enum.TryParse(typeof(Color), instrumentColor, out object color))
			{
				instrument.Color = (Color)color;
			}
			else
			{

			}
			
			instrument.ProductionYear = instrumentProductionYear;
			instrument.Price = instrumentPrice;

			_context.SaveChanges();

			return RedirectToAction("Index"); // Güncelleme tamamlandıktan sonra Index aksiyonuna yönlendir
		}

	}
}
