using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Domain.Common;

namespace BankApp.Domain.Entities
{
    public class BankAccount : EntityBase<Guid>
    {
        public Person? Owner { get; set; }
        public decimal Balance { get; set; }
    }
}