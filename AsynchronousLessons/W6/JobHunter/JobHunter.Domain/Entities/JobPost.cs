using JobHunter.Domain.Common;
using JobHunter.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunter.Domain.Entities
{
    public class JobPost : EntityBase<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company {  get; set; }
        public WorkMode WorkMode { get; set; }


        public JobPost() 
        {
            Id = Guid.NewGuid();
        }
    }
}
