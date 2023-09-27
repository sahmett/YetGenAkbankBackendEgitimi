using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelencerApp.Common
{
    internal class EntityBase<TKEY>
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
