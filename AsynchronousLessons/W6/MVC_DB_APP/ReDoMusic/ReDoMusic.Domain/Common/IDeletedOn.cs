using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoReMusic.Domain.Common
{
	internal interface IDeletedOn
	{
		public DateTime? DeletedOn { get; set; }
	}
}
