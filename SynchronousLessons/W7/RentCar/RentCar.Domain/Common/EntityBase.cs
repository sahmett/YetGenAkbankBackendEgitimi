using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Domain.Common
{
    public class EntityBase <Tkey> : ICreatedbyEntity, IModifiedByEntity, IDeletedByEntity
    {
        public Tkey Id { get; set;}
        public DateTime CreatedOn { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedByUserId { get; set; }
        public bool? IsDeleted { get; set; }
        DateTime? IDeletedByEntity.CreatedOn { get; set; }
    }
}
