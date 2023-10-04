using LibraryMaster.Abstract;
using LibraryMaster.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaster.Entity
{
    internal class Book : EntityBase<Guid>, ISaveable
    {
        public string Writer { get; set; }
        public string Title { get; set; }

        public string GetValues()
        {
            throw new NotImplementedException();
        }

        public void SetValues(string data)
        {
            throw new NotImplementedException();
        }
    }
}
