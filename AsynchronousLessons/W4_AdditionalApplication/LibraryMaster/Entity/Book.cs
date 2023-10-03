using LibraryMaster.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaster.Entity
{
    internal class Book : EntityBase<Guid>
    {
        public string Writer { get; set; }
        public string Title { get; set; }
    }
}
