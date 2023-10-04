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
            return $"{Writer},{Title}";
        }

        public void SetValues(string data)
        {
            string[] values = data.Split(',');
            if (values.Length == 2)
            {
                Writer = values[0];
                Title = values[1];
            }
            else
            {
                throw new ArgumentException("Veri dizesi uygun biçimde değil.");
            }
        }
    }
}
