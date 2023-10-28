using ReDoReMusic.Domain.Entities;

namespace ReDoReMusic.MVC.Models
{
    public class InstrumentViewModel
    {
        public List<Brand> Brands { get; set; }
        public List<Instrument> Instruments { get; set; }
        public Instrument Instrument { get; set; }
	}
}
