﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoReMusic.Domain.Common
{
	internal interface IModifiedOn
	{
		public DateTime? ModifiedOn { get; set; }
	}
}
