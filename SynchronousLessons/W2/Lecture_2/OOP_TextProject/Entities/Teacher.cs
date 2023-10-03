using OOPConsoleApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp.Entities
{
    public class Teacher : PersonBase
    {
        public DateTimeOffset RegistrationDate { get; set; }
    }
}
