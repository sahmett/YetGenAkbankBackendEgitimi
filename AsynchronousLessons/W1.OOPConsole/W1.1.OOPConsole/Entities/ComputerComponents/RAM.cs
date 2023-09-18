﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1._1.OOPConsole.Enums;

namespace W1._1.OOPConsole.Entities.ComputerComponents
{
    public class RAM
    {
        public string Brand { get; set; }
        public int Size { get; set; }


        public RAM(string brand, int size)
        {
            Brand = brand;
            Size = size;
        }
        public RAM() { }
    }
}

