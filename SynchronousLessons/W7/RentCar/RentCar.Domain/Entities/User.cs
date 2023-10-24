using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Domain.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address? Address { get; set; }
    }
}
