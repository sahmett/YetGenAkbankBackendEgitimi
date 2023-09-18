using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalPro.Entitiy
{
    public class Car
    {
        public Car(int ıd, string brand, string model)
        {
            Id = ıd;
            Brand = brand;
            Model = model;
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }

}
