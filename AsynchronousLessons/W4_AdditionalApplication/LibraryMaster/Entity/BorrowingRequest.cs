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


        // Bu metot, nesnenin verilerini bir metin formatında döndürür.
        // Örnek bir metin formatı kullanabilirsiniz.
        public string GetValues()
        {
            string data = $"{BorrowingBy.Name},{BorrowStartDate},{BorrowEndDate}";
            return data;

        }

        public void SetValues(string data)
        {
            string[] values = data.Split(',');
            if (values.Length == 4) ;
            {
                Id = Guid.Parse(values[0]);
                BorrowingBy = values[1];
                BorrowStartDate = DateTime.Parse(values[2]);
                BorrowEndDate = DateTime.Parse(values[3]);
            }
        }
    }
}
