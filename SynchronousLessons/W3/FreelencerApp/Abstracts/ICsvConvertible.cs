using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelencerApp.Abstracts
{
    internal interface ICsvConvertible
    {
        string GetValueCSV();
        void SetValueCSV(string csv);
    }
}
