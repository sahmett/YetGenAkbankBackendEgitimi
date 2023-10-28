using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReDoReMusic.Domain.Entities;
using ReDoReMusic.Domain.Enum;
using ReDoReMusic.MVC.Models;
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



		[HttpPost]
        public IActionResult UpdateInstrument(string id, [FromBody] UpdateInstrument updateInstrument) 
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

            //update instrument modelle baglantılı kısmı
            instrument.Name = updateInstrument.Name;
            instrument.Brand = updateInstrument.Brand;
            instrument.Model = updateInstrument.Model;
            instrument.Color = updateInstrument.Color;
            instrument.ProductionYear = updateInstrument.ProductionYear;
            instrument.Price = updateInstrument.Price;

            _context.SaveChanges();

            return AddInstrument();
        }



	}
}
