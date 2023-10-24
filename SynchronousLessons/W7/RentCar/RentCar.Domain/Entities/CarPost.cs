using RentCar.Domain.Common;
using RentCar.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Domain.Entities
{
    public class CarPost : EntityBase<Guid>
    {
        public Car Car { get; set; }
        public int Mileage { get; set; }
        public GearboxType GearboxType { get; set; }
        public CarColor CarColor { get; set; }


    }
}
