using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    internal class Triangel
    {
        public decimal Base { get; set; }
        public decimal Height { get; set; }

        public decimal ASide { get; set; }
        public decimal BSide { get; set; }


        public override decimal GetArea()
        {
            return ASide * BSide;
        }
    }
}
