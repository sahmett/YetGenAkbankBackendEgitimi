using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TextProject.Common
{
    public class EntitiyBase
    {
        public Guid id {  get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
