using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1._1.OOPConsole.Enums;
using W1._1.OOPConsole.ValueObjects;

namespace W1._1.OOPConsole.Entities.ComputerComponents
{
    public class Storage
    {

        public string Brand { get; set; }
        public Capacity Capacity { get; set; }

        public Storage() { }

        public Storage(string brand, Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;
        }
    }
}
