using ReDoReMusic.Domain.Common;
using ReDoReMusic.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoReMusic.Domain.Entities
{
	public class Instrument : EntityBase<Guid>
	{
		public string Name { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public Enum.Color Color { get; set; }
		public string ProductionYear { get; set; }
		public decimal Price { get; set; }
	}
}
