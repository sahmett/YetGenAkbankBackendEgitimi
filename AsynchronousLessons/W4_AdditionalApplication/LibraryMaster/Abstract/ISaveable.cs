using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaster.Abstract
{
    internal interface ISaveable
    {
        string GetValues();
        void SetValues();
    }
}
