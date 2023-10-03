using LibraryMaster.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaster.Entity
{
    internal class BorrowingRequest : EntityBase<Guid>
    {
        public User BorrowingBy { get; set; }
        public DateTime BorrowStartDate { get; set; }
        public DateTime BorrowEndDate { get; set; }

    }
}
