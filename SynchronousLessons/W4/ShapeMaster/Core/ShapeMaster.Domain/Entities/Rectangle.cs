using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    internal class Rectangle
    {
        public decimal ASide { get; set; }
        public decimal BSide { get; set; }

       public decimal GetArea()
        {
            return ASide * BSide;
        }

    }
}
