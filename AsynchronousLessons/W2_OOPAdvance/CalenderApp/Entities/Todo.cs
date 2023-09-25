using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalenderApp.Abstract;
using CalenderApp.Common;

namespace CalenderApp.Entities
{
    internal class Todo : Event, INotification
    { 
       
        public string Importance {get; set;}
        public void GetNotification()
        {
            Console.WriteLine($"{Importance} notification send");
        }

    }
}
