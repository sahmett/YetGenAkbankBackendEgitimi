using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalenderApp.Common;

namespace CalenderApp.Entities
{
    public class Meeting : Event
    {
        public List<string> Guests { get; set; }

    }
}
