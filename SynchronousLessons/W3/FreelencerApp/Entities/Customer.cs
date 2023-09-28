using FreelencerApp.Abstracts;
using FreelencerApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelencerApp.Entities
{
    internal class Customer : Person<Guid>, ICsvConvertible
    {
        public string PhoneNumber { get; set; }

        public string GetValuesCVS()
        {
            return $"{Id},{CreatedOn},{FirstName},{LastName},{PhoneNumber}";
        }
        public Customer() { }

        //6185ed04-2341-4f57-b06d-8c05e2ad9301,9/25/2023 10:00:21 PM +03:00,Bob,Smith,555-123-4567
        public void SetValuesCSV(string csvLine) 
        {
            string[] data = csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTime.Parse(data[1]); //offset ile farkı ne?
            FirstName = data[2];
            LastName = data[3];
            PhoneNumber = data[4];

        }
    }
}
