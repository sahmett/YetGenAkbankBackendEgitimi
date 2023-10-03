using LibraryMaster.Abstract;
using LibraryMaster.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaster.Entity
{
    internal class BorrowingRequest : EntityBase<Guid>, ISaveable
    {
        public User BorrowingBy { get; set; }
        public DateTime BorrowStartDate { get; set; }
        public DateTime BorrowEndDate { get; set; }

        public string GetValues()
        {
            throw new NotImplementedException();
        }

        public string SetValues()
        {
            throw new NotImplementedException();
        }
    }
}
