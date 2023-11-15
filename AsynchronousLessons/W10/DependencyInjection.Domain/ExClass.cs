using DependencyInjection.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Domain
{
	public class ExClass
	{
		private readonly IConfigurationService _configurationService;

		public ExClass(IConfigurationService configurationService)
		{
			_configurationService= configurationService;
		}

		public void ConfigurationMaker(string key)
		{
			_configurationService.GetValue(key);
		}
	}
}
