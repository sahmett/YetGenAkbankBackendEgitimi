using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1._1.OOPConsole.Entities.ComputerComponents;
using W1._1.OOPConsole.Enums;

namespace W1._1.OOPConsole.Entities
{
    internal class Computer
    {
        public int Id { get; set; }
        public string Brand {  get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }


        public Storage Storage { get; set; }
        public RAM RAM { get; set; }



        public Computer() { 
        Random random = new Random();
        Id = random.Next(1000, int.MaxValue);

        }

        public Computer(string brand, string model) : this()
        {
            Brand = brand.ToUpper();
            Model = model;
        }

        public Computer(string brand, string model, string cPU, RAM rAM, Storage storage) : this(brand, model)
        {
            CPU = cPU;
            RAM = rAM;
            Storage = storage;
        }

        /*
        public Computer(string cPU, string rAM, string storage, int storageSize, CapacitySizeType storageSizeTyoe) : this(cPU,rAM)
        {
            Storage = storage;
            StorageSize = storageSize;
            StorageSizeTyoe = storageSizeTyoe;
        }
        */

    }
}
