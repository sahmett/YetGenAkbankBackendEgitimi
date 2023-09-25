using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalenderApp.Abstract;
using CalenderApp.Common;

namespace CalenderApp.Entities
{
    public class Meeting : Event ,INotification
    {
        
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var item in Guests)
            {
                Console.WriteLine($" Notification send -> {item}");
            }
        }
    }
}
