using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaster.Common
{
    internal abstract class EntityBase<Tkey>
    {
        public Tkey Id { get; set; }
        public DateTimeOffset CretedOn { get; set; }
    }
}
