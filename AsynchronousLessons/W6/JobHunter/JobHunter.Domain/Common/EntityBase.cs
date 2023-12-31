﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunter.Domain.Common
{
	public class EntityBase<Tkey> : IModifiedByEntity, ICreatedByEntity
	{
		public Tkey Id { get; set; }
		public DateTime? ModifiedOn { get; set; }
		public DateTime CreatedOn { get; set; }

	}
}
