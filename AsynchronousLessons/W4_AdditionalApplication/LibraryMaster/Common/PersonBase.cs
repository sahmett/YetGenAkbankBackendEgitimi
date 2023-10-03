using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaster.Common
{
    internal abstract class PersonBase: EntityBase<Guid>
    {
        public string Name { get; set; }
        
    }
}

