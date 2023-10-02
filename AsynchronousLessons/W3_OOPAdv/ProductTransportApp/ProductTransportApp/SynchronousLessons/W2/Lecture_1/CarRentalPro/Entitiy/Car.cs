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
        public string Brand { get; set; }
        public Car(string brand)
        {
           
            Brand = brand;
         
        }

    }

}
