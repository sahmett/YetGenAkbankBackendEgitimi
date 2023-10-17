using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoReMusic.Domain.Common
{
	public class EntityBase<Tkey> : ICreatedOn, IModifiedOn, IDeletedOn
	{
		public Tkey Id { get; set; }
		public DateTime CreatedOn { get; set; }
		public DateTime? ModifiedOn { get; set; }
		public DateTime? DeletedOn { get; set; }
	}
}
