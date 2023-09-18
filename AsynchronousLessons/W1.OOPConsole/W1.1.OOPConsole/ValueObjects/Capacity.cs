﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1._1.OOPConsole.Enums;

namespace W1._1.OOPConsole.ValueObjects
{
    public class Capacity
    {
        public int Size { get; set; }
        public CapacitySizeType SizeType { get; set; }

        public Capacity(int size, CapacitySizeType sizeType)
        {
            Size = size;
            SizeType = sizeType;
        }
    }
}
