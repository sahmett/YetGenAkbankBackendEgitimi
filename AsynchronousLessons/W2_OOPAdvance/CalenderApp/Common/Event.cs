using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderApp.Common
{
    public class Event
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<string> Details { get; set; }
        public string Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Event(string title, List<string> details, string type, DateTime startTime, DateTime endTime)
        {
            Id = Guid.NewGuid();
            Title = title;
            Details = details;
            Type = type;
            StartTime = startTime;
            EndTime = endTime;
        }
        public Event()
        {

        }

    }
}
