using ReDoReMusic.Domain.Entities;
using ReDoReMusic.Domain.Enum;

namespace ReDoReMusic.MVC.Models
{
    public class UpdateInstrument
    {
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public Domain.Enum.Color Color { get; set; }
        public string ProductionYear { get; set; }
        public decimal Price { get; set; }
    }
}
