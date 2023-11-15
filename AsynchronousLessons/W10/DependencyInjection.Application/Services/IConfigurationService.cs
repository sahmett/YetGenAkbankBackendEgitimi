
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Application.Services
{
	public interface IConfigurationService
	{
		IConfigurationService GetInstance();

		string GetValue(string key);

	}
}
