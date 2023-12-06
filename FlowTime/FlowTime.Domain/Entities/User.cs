using FlowTime.Domain.Common;
using FlowTime.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlowTime.Domain.Entities
{
    public class User : EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int WorkTime { get; set; }
        public bool IsGraduated { get; set; }
        public Int16 Age { get; set; }
        public Gender Gender { get; set; }
    }
}
