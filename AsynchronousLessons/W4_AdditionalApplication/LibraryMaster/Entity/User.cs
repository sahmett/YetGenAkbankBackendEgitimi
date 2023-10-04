using LibraryMaster.Abstract;
using LibraryMaster.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaster.Entity
{
    internal class User : PersonBase, ISaveable
    {
        public string UserDetail { get; set; }

        public string GetValues()
        {
           
            return UserDetail;
        }

        public void SetValues(string data)
        {
            
            UserDetail = data;
        }
    }
}
