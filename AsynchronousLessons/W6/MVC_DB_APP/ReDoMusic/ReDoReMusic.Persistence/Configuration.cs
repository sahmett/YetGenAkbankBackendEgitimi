using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoReMusic.Persistence
{
    public static class Configuration
    {
		public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();
            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).FullName}" + //ana klasör 6 seviyesi
				$"\\ReDoReMusic.Persistence\\";

            configurationManager.SetBasePath(path);
            configurationManager.AddJsonFile("PrivateInformation.json");

            return configurationManager.GetSection(key).Value; //altına girmek için : kullanılır
        }
    }
}
