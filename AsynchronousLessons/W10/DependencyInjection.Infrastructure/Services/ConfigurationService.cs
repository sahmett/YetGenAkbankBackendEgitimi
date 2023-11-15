using DependencyInjection.Application.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Infrastructure.Services
{
	public class ConfigurationService : IConfigurationService
	{
		public static ConfigurationService instance { get; set; }
		
		public ConfigurationService() 
		{
			Console.WriteLine("ConfigurationService()  instance created  >  in infrastructure");
		}

		public  IConfigurationService GetInstance() { 
			if (instance is null)
				instance = new ConfigurationService();

			Console.WriteLine("GetInstance >  in infrastructure");

			return (ConfigurationService)instance;
		}

		public string GetValue(string key)
		{
			ConfigurationManager configurationManager = new();

			string path = Directory.GetCurrentDirectory();

			configurationManager.SetBasePath(path);
			configurationManager.AddJsonFile("appsettings.json");

			Console.WriteLine("GetValue >  in infrastructure");

			return configurationManager.GetSection(key).Value;

		}


	}
}
