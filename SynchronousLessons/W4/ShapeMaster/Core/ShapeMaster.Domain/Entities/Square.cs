using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    internal class Square : Shape
    {
        public decimal ASide { get; set; }


        public override decimal GetArea()
        {
            return ASide * ASide;
        }
    }
}
